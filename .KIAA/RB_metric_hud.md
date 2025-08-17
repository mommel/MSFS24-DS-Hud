# RB — Metric HUD Telemetry

**Goal** — Display current altitude and airspeed in metric units within an unobtrusive in-sim UI.

**Acceptance Criteria**
- Altitude shown simultaneously in feet and meters.
- Airspeed shown simultaneously in knots and km/h.
- Data sourced from MSFS 2024 via SimConnect.

**Questions & Findings**
| # | Question | Finding | Confidence | Evidence |
|---|---|---|---|---|
| 1 | Which SimVars expose altitude and airspeed? | `PLANE ALTITUDE` (feet) and `AIRSPEED INDICATED` (knots) provide the required data. | Medium | [S1] |
| 2 | How to convert feet to meters? | Multiply by 0.3048. | High | [S2] |
| 3 | How to convert knots to km/h? | Multiply by 1.852. | High | [S3] |

**Constraints/Assumptions**
- C# and .NET 8.0 using SimConnect SDK.
- Runs as external SimConnect client initially.

**Options Matrix**
| Option | Perf | Rel | Maint | Compat | DX | Speed | Total |
|---|---|---|---|---|---|---|---|
| External SimConnect client | 4 | 4 | 5 | 5 | 4 | 4 | 26 |
| In-game WASM gauge | 5 | 5 | 3 | 4 | 3 | 2 | 22 |

**Decision & Rationale** — Start with external SimConnect client for faster iteration and simpler tooling, while remaining compatible with MSFS Community mods.

**Risks & Mitigations**
| Risk | Mitigation |
|---|---|
| SimConnect API changes in MSFS 2024 | Encapsulate interactions behind interface for future adaptation. |

**Sources**
- [S1] Microsoft Flight Simulator 2024 SDK – SimConnect API Reference (access attempted)
- [S2] NIST Handbook of Metric Conversion Factors, 0.3048 meters per foot
- [S3] ICAO Speed Unit Guidance, 1 knot = 1.852 km/h
