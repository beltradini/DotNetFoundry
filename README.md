# DotNetFoundry

DotNetFoundry is a structured C# and .NET engineering laboratory built to learn the .NET ecosystem through theory, deliberate practice, testing, and progressively more complete software projects.

## Objectives

- Master modern C# fundamentals and language features.
- Understand the .NET SDK, CLI, runtime, project system, and NuGet ecosystem.
- Apply object-oriented and functional programming concepts in practical code.
- Build automated tests from the beginning.
- Progress toward ASP.NET Core, Entity Framework Core, PostgreSQL, Docker, and CI/CD.
- Document important comparisons between Swift and C# where they improve understanding.

## Learning Roadmap

### Phase 1 — C# Fundamentals

- Types and variables
- Functions and control flow
- Classes
- Structs
- Records
- Interfaces
- Collections

### Phase 2 — Modern C#

- Generics
- LINQ
- Delegates and lambdas
- Pattern matching
- Nullable reference types
- Exceptions
- Async/await

### Phase 3 — .NET Engineering

- Dependency injection
- Configuration
- Logging
- Testing
- Class libraries

### Phase 4 — ASP.NET Core

- REST APIs
- Middleware
- Validation
- Authentication and authorization

### Phase 5 — Persistence

- Entity Framework Core
- PostgreSQL
- Migrations
- Relationships and queries

### Phase 6 — Production

- Docker
- GitHub Actions
- Observability
- Deployment

## Repository Structure

The repository will evolve toward:

```text
DotNetFoundry/
├── docs/        # Theory and engineering notes
├── exercises/   # Focused practice problems
├── src/         # Applications and libraries
└── tests/       # Automated tests
```

## Development Environment

- macOS
- .NET 10 SDK
- C#
- Visual Studio Code + C# Dev Kit
- Git + GitHub

## Philosophy

Each concept should progress through four stages:

1. Understand the theory.
2. Compare it with familiar programming concepts when useful.
3. Implement it without copying a finished solution.
4. Verify the behavior with tests or observable output.

The repository is intentionally incremental: early console programs will evolve into production-oriented .NET applications.