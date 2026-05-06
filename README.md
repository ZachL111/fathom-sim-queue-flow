# fathom-sim-queue-flow

`fathom-sim-queue-flow` is a C# project in simulations. Its focus is to create a C# reference implementation for queue workflows, centered on graph analysis, node-edge fixtures, and cycle and reachability reports.

## Problem It Tries To Make Smaller

The point is to make a small domain rule concrete enough that a reader can change it and immediately see what broke.

## Fathom Sim Queue Flow Review Notes

Start with `input pressure` and `review cost`. Those cases create the widest score spread in this repo, so they are the best quick check when the model changes.

## Working Pieces

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/fathom-sim-queue-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `input pressure` and `review cost`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Design Notes

The core code exposes a scoring path and the added review layer uses `signal`, `slack`, `drag`, and `confidence`. The domain terms are `input pressure`, `state drift`, `review cost`, and `decision risk`.

The C# code keeps the review rule close to the tests.

## Example Run

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Tests

The same command runs the local verification path. The highest-scoring domain case is `stale` at 214, which lands in `ship`. The most cautious case is `edge` at 137, which lands in `watch`.

## Known Limits

This remains a local project with deterministic fixtures. It does not depend on credentials, hosted services, or live data. Future work should add richer malformed inputs before widening the public API.
