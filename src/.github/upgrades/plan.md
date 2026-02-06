# .NET Upgrade Plan

## Table of Contents
- [Executive Summary](#executive-summary)
- [Migration Strategy](#migration-strategy)
- [Detailed Dependency Analysis](#detailed-dependency-analysis)
- [Project-by-Project Plans](#project-by-project-plans)
- [Package Update Reference](#package-update-reference)
- [Breaking Changes Catalog](#breaking-changes-catalog)
- [Testing & Validation Strategy](#testing--validation-strategy)
- [Risk Management](#risk-management)
- [Complexity & Effort Assessment](#complexity--effort-assessment)
- [Source Control Strategy](#source-control-strategy)
- [Success Criteria](#success-criteria)

## Executive Summary
### Scenario
Upgrade `Fleck` solution to a newer .NET version using an all-at-once update across all projects.

### High-level Metrics
- Projects: 1 (`Fleck.csproj`)
- Project type: ClassLibrary (SDK-style)
- Current target frameworks: `net40;net45;netstandard2.0;netcoreapp2.0`
- Proposed target frameworks (confirmed): `net40;net45;netstandard2.0;netcoreapp2.0;net10.0`
- NuGet packages: 0
- Total LOC: 1819
- API compatibility issues: 0 (1861 APIs analyzed, all compatible)

### Complexity Classification
**Simple** — single project, no dependencies, no package updates, no API issues.

### Selected Strategy
**All-At-Once Strategy** — all projects upgraded simultaneously in a single coordinated operation.

### Iteration Strategy
Simple solution: complete plan in a small number of iterations with a single batch of project details.

## Migration Strategy
### Approach Selection
**All-At-Once Strategy** is appropriate because:
- Only 1 project in the solution.
- No dependencies or complex ordering.
- No package updates or API incompatibilities reported.

### Execution Approach (Planning Only)
- Perform a single coordinated upgrade of all target frameworks in `Fleck.csproj`.
- No intermediate states are required due to single-project scope.

### Ordering
- No dependency ordering constraints.
- Apply target framework changes and any required package updates in one atomic operation.

## Detailed Dependency Analysis
### Dependency Graph Summary
- Single project: `Fleck.csproj`
- No project dependencies
- No dependants
- No circular dependencies

### Migration Grouping
- Single atomic group containing `Fleck.csproj`.

### Critical Path
- None (no dependencies).

## Project-by-Project Plans
### Project: `Fleck.csproj`
**Current State**:
- Target frameworks: `net40;net45;netstandard2.0;netcoreapp2.0`
- Project kind: ClassLibrary (SDK-style)
- Dependencies: 0
- LOC: 1819

**Target State**:
- Proposed target frameworks (confirmed): `net40;net45;netstandard2.0;netcoreapp2.0;net10.0`

**Migration Steps**:
1. Update `TargetFrameworks` to include `net10.0`.
2. Ensure multi-targeting remains consistent with existing frameworks.
3. Restore and build to confirm compatibility (planning checkpoint).

**Package Updates**: None (no packages listed in assessment).

**Expected Breaking Changes**:
- None identified in assessment; verify during build.

**Code Modifications**:
- None identified; review only if build reveals issues.

**Testing Strategy**:
- Build validation only (no test projects listed).

**Validation Checklist**:
- [ ] Project builds without errors
- [ ] No new warnings introduced
- [ ] Target framework list matches agreed version(s)

## Package Update Reference
No package updates were identified in the assessment.

## Breaking Changes Catalog
- No breaking changes were flagged in the assessment.
- Validate during build to detect any framework or tooling issues.

## Testing & Validation Strategy
### Build Validation
- Build the solution after framework update to confirm no compile errors.
- Validate all target frameworks listed in `TargetFrameworks`.

### Test Execution
- No test projects identified in assessment.
- If tests exist outside assessment scope, run relevant suites after build.

## Risk Management
### High-Level Risks
| Risk | Level | Description | Mitigation |
| --- | --- | --- | --- |
| Multi-targeting complexity | Low | Multiple target frameworks must remain compatible | Validate build across all TFMs |

## Complexity & Effort Assessment
| Project | Complexity | Rationale |
| --- | --- | --- |
| `Fleck.csproj` | Low | Single project, no dependencies, no package updates, no API issues |

## Source Control Strategy
- Use a single upgrade branch (`upgrade-to-NET10`).
- Prefer a single atomic commit for all framework updates and related fixes.
- Ensure `plan.md` and final changes are reviewed together in one PR.

## Success Criteria
### Technical Criteria
- All projects target the agreed framework version(s).
- Solution builds without errors or new warnings.
- No dependency conflicts.

### Quality Criteria
- No regressions introduced by target framework change.

### Process Criteria
- All-at-once upgrade completed in a single coordinated operation.
