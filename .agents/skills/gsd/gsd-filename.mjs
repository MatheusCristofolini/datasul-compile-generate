#!/usr/bin/env node
/**
 * GSD Filename Generator
 *
 * Generates deterministic, timestamp-prefixed filenames for GSD artifacts.
 * Format: <YYYY-MM-DD_HH-mm>-<identifier>
 *
 * Usage (CLI):
 *   node gsd-filename.mjs <identifier>
 *   node gsd-filename.mjs 1-CONTEXT        → 2026-03-17_14-30-1-CONTEXT
 *   node gsd-filename.mjs 2-1-PLAN         → 2026-03-17_14-30-2-1-PLAN
 *
 * Usage (import):
 *   import { gsdFilename } from './.agent/skills/gsd/gsd-filename.mjs'
 *   gsdFilename('1-CONTEXT')               → '2026-03-17_14-30-1-CONTEXT'
 */

/**
 * Returns the current local time formatted as YYYY-MM-DD_HH-mm.
 * Uses local time so filenames match the developer's timezone.
 */
function currentTimestamp() {
  const now = new Date()
  const pad = n => String(n).padStart(2, '0')
  const yyyy = now.getFullYear()
  const mm = pad(now.getMonth() + 1)
  const dd = pad(now.getDate())
  const hh = pad(now.getHours())
  const min = pad(now.getMinutes())
  return `${yyyy}-${mm}-${dd}_${hh}-${min}`
}

/**
 * Returns a GSD filename string (without .md extension).
 * The orchestrator appends .md when writing the file.
 *
 * @param {string} identifier  e.g. "1-CONTEXT", "2-1-PLAN", "STATE"
 * @returns {string}           e.g. "2026-03-17_14-30-1-CONTEXT"
 */
export function gsdFilename(identifier) {
  if (!identifier || typeof identifier !== 'string') {
    throw new Error('gsdFilename: identifier must be a non-empty string')
  }
  return `${currentTimestamp()}-${identifier}`
}

// ── CLI entry point ──────────────────────────────────────────────────────────
import { fileURLToPath } from 'node:url'
import { resolve } from 'node:path'

if (process.argv[1] && resolve(process.argv[1]) === resolve(fileURLToPath(import.meta.url))) {
  const identifier = process.argv[2]
  if (!identifier) {
    console.error('Usage: node gsd-filename.mjs <identifier>')
    console.error('Example: node gsd-filename.mjs 1-CONTEXT')
    process.exit(1)
  }
  console.log(gsdFilename(identifier))
}
