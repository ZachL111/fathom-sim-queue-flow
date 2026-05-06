# Fathom Sim Queue Flow Walkthrough

The fixture is intentionally compact, so the review starts with the cases that pull farthest apart.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 160 | ship |
| stress | state drift | 166 | ship |
| edge | review cost | 137 | watch |
| recovery | decision risk | 180 | ship |
| stale | input pressure | 214 | ship |

Start with `stale` and `edge`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

The useful comparison is `input pressure` against `review cost`, not the raw score alone.
