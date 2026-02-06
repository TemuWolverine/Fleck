# Upgrade Tasks

## Overview
- Scenario: Upgrade `Fleck` to `.NET 10.0` (multi-targeting)
- Branch: `upgrade-to-NET10`
- Plan reference: `.github/upgrades/plan.md`

## Tasks

### [?] TASK-001: Validate .NET SDK and baseline build readiness
- [ ] (1) Validate .NET SDK supports `net10.0` on this machine
- [ ] (2) Verify `global.json` (if present) is compatible with `net10.0`

### [ ] TASK-002: Update target frameworks in `Fleck.csproj`
- [ ] (1) Update `TargetFrameworks` to include `net10.0`
- [ ] (2) Verify `TargetFrameworks` is set to `net40;net45;netstandard2.0;netcoreapp2.0;net10.0`

### [ ] TASK-003: Restore and build solution
- [ ] (1) Restore packages for `Fleck.sln`
- [ ] (2) Build `Fleck.sln` and verify no errors

### [ ] TASK-004: Final verification and documentation
- [ ] (1) Ensure `plan.md` and `assessment.md` are unchanged post-execution
- [ ] (2) Summarize changes in `execution_log.md`
