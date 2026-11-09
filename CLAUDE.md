# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

GemJam is a jewelry e-commerce site built as an ASP.NET Core MVC app (single project, root namespace `GemJam`). It follows an online course (BulkyBook, adapted from books to jewelry) lecture by lecture, so the project should stay at the same point as the course: no extra features, pages, or CSS beyond what is asked.

## Tech stack

- **Runtime/framework:** .NET 11 (`net11.0`), ASP.NET Core MVC (Razor views, `AddControllersWithViews`), nullable reference types and implicit usings enabled
- **Data:** Entity Framework Core 11 (preview/RC packages) with the SQL Server provider, code-first migrations (`Microsoft.EntityFrameworkCore.SqlServer`, `.Design`, `.Tools`)
- **Database:** SQL Server (dev connection is `localhost\SQLEXPRESS`, Windows auth)
- **Front end:** Bootstrap 5.3.8 and Bootstrap Icons 1.13.1 from the jsDelivr CDN, jQuery (local, `wwwroot/lib`), jQuery Validation (local, not wired in yet), plain CSS in `wwwroot/css/site.css`
- **Tooling:** `dotnet` CLI and `dotnet ef`, Git with GitHub (`Joe0mran/GemJam`), VS Code

## Commands

- Build: `dotnet build`
- Run: `dotnet run --launch-profile http` (serves `http://localhost:5255`; the https profile uses `https://localhost:7070`)
- Add migration: `dotnet ef migrations add <Name>`; apply: `dotnet ef database update`
- There are no tests or linters configured.

## Architecture

- `Program.cs` registers `ApplicationDBContext` with SQL Server using the connection string named **`SQLConnection`**, read from `appsettings.Development.json`. The `localhost\SQLEXPRESS` Windows-auth string only works on Windows; on a machine without a reachable SQL Server, pages that query the database (Category) return a 500.
- `Data/ApplicationDBContext.cs` holds the `Categories` DbSet and the **seed data** in `OnModelCreating` via `HasData`. Changing seeds requires a new migration.
- `Models/Category.cs`: the primary key is `CategoryId` (not `Id`; don't rename it), plus `Name` and `DisplayOrder`.
- `Controllers/CategoryController.cs` injects the DbContext and `Index()` returns `View("index", categories)`. The view file is the lowercase `Views/Category/index.cshtml` to match, so keep that casing (Linux is case-sensitive).
- `Views/Shared/_Layout.cshtml` is the single layout. It has a dark sticky navbar, a footer, "Gem" plus green "Jam" branding with the `bi-gem` icon, and the tagline "Timeless Jewelry, Crafted for You". The local `wwwroot/lib/bootstrap` folder is kept but unused for CSS/JS.
- `wwwroot/css/site.css` is deliberately minimal and currently holds only the `.table-styled` rules.

## Git

- Branches are per course section (e.g. `Section-2`) and get merged into `main` when finished. Run `git merge main` before starting a new section so the branches don't diverge.
- `bin/` and `obj/` are gitignored. Never commit them; tracking them previously caused constant merge conflicts.
- `origin` uses SSH (`git@github.com:Joe0mran/GemJam.git`). HTTPS pushes fail because no credentials are configured.
