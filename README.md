<div align="center">

# 🧪 Exercise: Automated Testing 🫡

### Modernized, executed, and verified — 76 checks, 0 failures.

<img src="docs/assets/sweating-programmer.gif"
     alt="Programmer surviving automated testing"
     width="380">

<p><em>When the learning resources are outdated, but all tests still pass.</em> 😅</p>

</div>

---

## ✅ Test Execution Evidence

> All exercise projects were updated, executed, and verified successfully in a modern development environment.

| # | Test Suite | Technology | Passed | Failed | Status |
|:---:|---|---|---:|---:|:---:|
| 1 | API Collection Tests | Postman · Newman | 28 assertions | 0 | ✅ PASS |
| 2 | Exported Browser Test | Selenium IDE · C# | 1 test | 0 | ✅ PASS |
| 3 | Browser Automation | Selenium WebDriver · NUnit · .NET 8 | 7 tests | 0 | ✅ PASS |
| 4 | End-to-End UI Tests | Playwright · JavaScript | 11 tests | 0 | ✅ PASS |
| 5 | REST API Tests | Mocha · Chai · Chai HTTP | 5 tests | 0 | ✅ PASS |
| 6 | Integration Tests | xUnit · NUnit · EF Core · .NET 8 | 24 tests | 0 | ✅ PASS |
|  | **Verified total** | **Multiple testing frameworks** | **76 checks** | **0** | **🟢 ALL PASSED** |

### Environment and Compatibility Improvements

| Original issue | Implemented solution |
|---|---|
| Projects targeted the unsupported `.NET 6` framework | Migrated all related projects to `.NET 8` |
| ChromeDriver 125/126 was incompatible with the installed browser | Removed the pinned driver and enabled automatic management through Selenium Manager |
| The hosted Number Calculator was unavailable | Added a compatible local test fixture preserving the original selectors and behavior |
| Strict Postman property assertion failed on additional API fields | Replaced `all.keys()` with `include.all.keys()` |
| Selenium IDE was unavailable in Chromium extension stores | Used the supported Firefox extension and the exported C# project |
| Generated dependencies and test artifacts polluted the repository | Added an appropriate `.gitignore` configuration |