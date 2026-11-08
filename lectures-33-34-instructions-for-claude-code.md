# Instructions for Claude Code — replicate Lectures 33 & 34 (styling + Category list UI)

Context: I'm following an ASP.NET Core MVC course where the instructor builds BulkyBook (a bookstore). I'm building my **own e-commerce site for GemJam, a jewelry store** — same structure, but jewelry instead of books. I want to stay **exactly at the same point as the course** — no extra features, no extra pages, no extra CSS. Only do what's listed below.

## My project's details (GemJam)
- Single project; root namespace is **`GemJam`** (models in `GemJam.Models`, DbContext is `ApplicationDBContext` in `GemJam.Data`).
- `Category` model primary key is **`CategoryId`** (not `Id`), plus `Name`.
- Seeded categories: Rings, Earings, Bracelets, Necklaces, Bangles, Piercings, Colliers.
- `_Layout.cshtml` is still the default .NET template (`navbar-expand-sm navbar-light bg-white`, local Bootstrap from `~/lib/bootstrap`, `~/GemJam.styles.css`).

## Step 0 — Check first (do not skip)
These should already exist from the previous lectures (28–32). My GitHub may be behind my local code, so **check the local files**:
1. `Category` has an `int DisplayOrder` property (and a migration for it).
2. `Controllers/CategoryController.cs` injects `ApplicationDBContext` and `Index()` returns `View(_db.Categories.ToList())`.
3. `Views/Category/Index.cshtml` exists with `@model List<Category>`.
4. The navbar has a "Category" link (`asp-controller="Category" asp-action="Index"`).

If any of these are missing, **stop and tell me which ones** — don't build them silently, so I stay in sync with the course.

**Branding:** everywhere the snippets below say "BulkyBook", use **GemJam** instead (brand shown as "Gem" + green "Jam"). Tagline: "Timeless Jewelry, Crafted for You". Use the `bi-gem` Bootstrap icon instead of `bi-book`. Keep everything else (colors, layout, classes) the same.

---

## Lecture 33 — Modify Styling for Final Project Design

### 1. Images
- Create folder `wwwroot/images/` (name must be exactly `images`).
- Add a small logo icon there named `gem.png` (a simple placeholder gem/diamond PNG is fine — I'll swap in the real GemJam logo later).

### 2. `Views/Shared/_Layout.cshtml`
Keep `<title>@ViewData["Title"] - GemJam</title>`, the `importmap` script, and the `~/css/site.css` + `~/GemJam.styles.css` links. Don't delete the `wwwroot/lib/bootstrap` folder.

**a) In `<head>`:** delete only the `~/lib/bootstrap/dist/css/bootstrap.min.css` link and replace it with these pinned CDN versions:
```html
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" crossorigin="anonymous" />
<link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css" rel="stylesheet" />
```

**b) At the bottom:** replace the local `bootstrap.bundle.min.js` script with:
```html
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
```
(keep jQuery, `site.js`, and `@await RenderSectionAsync("Scripts", required: false)`).

**c) `<body>`:** `<body class="d-flex flex-column min-vh-100" style="background-color:#f5f5f5">`

**d) `<header>`:** `<header class="sticky-top">`

**e) `<nav>`:** replace `navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3` with:
`<nav class="navbar navbar-expand-lg navbar-dark" style="background-color:#191414">`
- Inner div: `container` (not `container-fluid`).
- Remove `text-dark` from all nav links.

**f) Brand anchor** — replace the default `navbar-brand` link with:
```html
<a class="navbar-brand d-flex align-items-center gap-2" asp-area="" asp-controller="Home" asp-action="Index">
    <div class="d-flex align-items-center justify-content-center rounded" style="width: 36px; height: 36px; background: rgba(255,255,255,0.2);">
        <img src="/images/gem.png" style="width: 24px; height: 24px;" />
    </div>
    <span class="fw-bold fs-5 d-none d-sm-inline">Gem<span style="color: #1DB954;">Jam</span></span>
</a>
```

**g) Toggler + collapse (fixes mobile view):**
```html
<button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target=".navbar-collapse"
        aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
</button>
<div class="navbar-collapse collapse">
    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <!-- keep existing Home, Privacy, Category nav-items -->
    </ul>
</div>
```
(Only `navbar-collapse collapse` on the div — no `d-sm-inline-flex justify-content-between`, no `flex-grow-1`. The `ul` is `me-auto mb-2 mb-lg-0`.)

**h) Main body wrapper:** change `<div class="container">` around `<main>` to `<div class="flex-grow-1">` (main stays `<main role="main" class="pb-3">@RenderBody()</main>`).

**i) Footer** — replace the default footer with:
```html
<footer class="mt-auto py-4" style="background: #0D0D0D;">
    <div class="container">
        <div class="row align-items-center gy-3">
            <div class="col-sm-4 d-flex align-items-center gap-3">
                <div class="d-flex align-items-center justify-content-center rounded-circle" style="width: 40px; height: 40px; background: #17A34A;">
                    <i class="bi bi-gem fs-5" style="color: #0D0D0D;"></i>
                </div>
                <div>
                    <p class="mb-0 fw-semibold text-white small">GemJam</p>
                    <p class="mb-0 text-secondary" style="font-size: 0.75rem;">Timeless Jewelry, Crafted for You</p>
                </div>
            </div>
            <div class="col-sm-4 text-center">
                <p class="mb-0 text-secondary small">&copy; @DateTime.Now.Year GemJam. All rights reserved.</p>
            </div>
            <div class="col-sm-4 d-flex justify-content-sm-end justify-content-center gap-2">
                <a href="#" class="btn btn-sm rounded-circle d-flex align-items-center justify-content-center" style="width: 32px; height: 32px; background: rgba(255,255,255,0.1);"><i class="bi bi-twitter-x text-secondary small"></i></a>
                <a href="#" class="btn btn-sm rounded-circle d-flex align-items-center justify-content-center" style="width: 32px; height: 32px; background: rgba(255,255,255,0.1);"><i class="bi bi-facebook text-secondary small"></i></a>
                <a href="#" class="btn btn-sm rounded-circle d-flex align-items-center justify-content-center" style="width: 32px; height: 32px; background: rgba(255,255,255,0.1);"><i class="bi bi-instagram text-secondary small"></i></a>
            </div>
        </div>
    </div>
</footer>
```

### 3. `wwwroot/css/site.css`
The instructor deleted everything in `site.css` and pasted his big custom stylesheet (mostly for future pages). **Keep it minimal**: delete the default contents and add ONLY the table style needed now:
```css
.table-styled { border-collapse: collapse; width: 100%; }
.table-styled thead th {
    background: #f8fafc; font-size: 0.7rem; font-weight: 600; text-transform: uppercase;
    letter-spacing: 0.05em; color: #94a3b8; padding: 0.875rem 1.25rem;
    border-bottom: 2px solid #e2e8f0; border-top: none; white-space: nowrap;
}
.table-styled tbody td {
    padding: 0.875rem 1.25rem; font-size: 0.875rem; color: #475569;
    border-bottom: 1px solid #f1f5f9; vertical-align: middle;
}
.table-styled tbody tr { transition: background 0.15s; }
.table-styled tbody tr:hover { background: #f8fafc; }
.table-styled tbody tr:last-child td { border-bottom: none; }
```

---

## Lecture 34 — Display Category UI

Replace `Views/Category/Index.cshtml` with this:
```cshtml
@using GemJam.Models
@model List<Category>

<div class="container-fluid py-4">
    <div class="card border shadow-sm overflow-hidden">
        <div class="card-header text-white py-3 px-4 d-flex align-items-center justify-content-between"
             style="background: linear-gradient(to right, #065f46, #282828, #191414);">
            <div>
                <h5 class="mb-0 fw-bold"><i class="bi bi-grid me-2"></i>Categories</h5>
                <p class="mb-0 small" style="color: #1DB954;">Manage your jewelry categories</p>
            </div>
            <a asp-controller="Category" asp-action="Create"
               class="btn btn-sm btn-outline-light fw-semibold d-inline-flex align-items-center gap-1">
                <i class="bi bi-plus-lg"></i> New Category
            </a>
        </div>
        <div class="table-responsive">
            <table class="table-styled">
                <thead>
                    <tr>
                        <th>Category Name</th>
                        <th>Display Order</th>
                        <th class="text-end">Actions</th>
                    </tr>
                </thead>
                <tbody>
                    @foreach (var obj in Model)
                    {
                        <tr>
                            <td class="fw-medium" style="color: #1e293b;">@obj.Name</td>
                            <td><span class="badge bg-light text-dark border">@obj.DisplayOrder</span></td>
                            <td class="text-end">
                                <a href="#" class="btn btn-sm btn-outline-success me-1"><i class="bi bi-pencil-square me-1"></i>Edit</a>
                                <a href="#" class="btn btn-sm btn-outline-danger"><i class="bi bi-trash me-1"></i>Delete</a>
                            </td>
                        </tr>
                    }
                </tbody>
            </table>
        </div>
    </div>
</div>
```

---

## Do NOT do (the course hasn't reached these yet)
- Do **not** create the `Create` action or `Create.cshtml` view. Clicking "New Category" should give a 404 for now — that's expected (next lecture).
- Edit/Delete buttons stay `href="#"` (not wired up).
- No validation, TempData, toastr, partial views, repository pattern, product pages, home page redesign, dark-mode toggle, or extra CSS.
- No changes to the controller, model, DbContext, seed data, or migrations (don't rename `CategoryId` to `Id`).

## When done
Build the project (`dotnet build`) and make sure it compiles with no errors, then list the files you changed.

## Expected result
Dark sticky navbar with gem logo + two-tone "GemJam" name, collapses correctly on mobile; dark footer stuck to the bottom; Category page shows a card with a green/dark gradient header, "New Category" button, and a clean table listing each category's name and display order with Edit/Delete buttons.
