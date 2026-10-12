const https = require('https');

function fetchRedditTop(subreddit, timeframe) {
    if (!subreddit) {
        console.error('Please provide a subreddit name. Example: node scrape.js n8n');
        process.exit(1);
    }

    const url = `https://www.reddit.com/r/${subreddit}/top.json?limit=3&t=${timeframe}`;
    const options = {
        headers: {
            'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36'
        }
    };

    https.get(url, options, (res) => {
        let data = '';

        // A chunk of data has been received.
        res.on('data', (chunk) => {
            data += chunk;
        });

        // The whole response has been received.
        res.on('end', () => {
            if (res.statusCode === 301 || res.statusCode === 302) {
                console.error(`Subreddit might not exist or redirection occurred (Status ${res.statusCode}).`);
                process.exit(1);
            }
            if (res.statusCode !== 200) {
                console.error(`Failed to fetch from Reddit. Status code: ${res.statusCode}`);
                if (res.statusCode === 429) {
                    console.error('Rate limited by Reddit API.');
                }
                process.exit(1);
            }

            try {
                const parsed = JSON.parse(data);
                const posts = parsed.data.children;
                if (!posts || posts.length === 0) {
                    console.log(`No posts found for subreddit: r/${subreddit} today.`);
                    return;
                }

                console.log(`\nTop ${posts.length} Posts from r/${subreddit} (today):\n`);
                posts.forEach((post, i) => {
                    const p = post.data;
                    console.log(`${i + 1}. ${p.title}`);
                    console.log(`   Author: u/${p.author}`);
                    console.log(`   Score: ${p.score}`);
                    console.log(`   URL: https://www.reddit.com${p.permalink}\n`);
                });
            } catch (err) {
                console.error('Error parsing JSON:', err.message);
                console.error('Response received:', data.substring(0, 100) + '...');
            }
        });
    }).on('error', (err) => {
        console.error('Error making HTTP request:', err.message);
    });
}

const subreddit = process.argv[2];
const timeframe = process.argv[3] || 'day';
fetchRedditTop(subreddit, timeframe);
