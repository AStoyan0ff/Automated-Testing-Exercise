<div align="center">

    🧪 Exercise: Automated Testing 🫡

    Modernized, executed, and verified — 76 checks, 0 failures.

    <img src="docs/assets/evil-hacker.gif" alt="Animated evil hacker coding" width="520">

    <p><em>Outdated resources detected. Compatibility restored. All tests passed.</em> 🟢</p>

</div>

---

## Test Execution Evidence

All exercise projects were updated, executed, and verified successfully in a modern development environment.

| # | Test suite | Technology | Passed | Failed | Status |
|:---:|---|---|---:|---:|:---:|
| 1 | API Collection Tests | Postman Â· Newman | 28 assertions | 0 | PASS |
| 2 | Exported Browser Test | Selenium IDE Â· C# | 1 test | 0 | PASS |
| 3 | Browser Automation | Selenium WebDriver Â· NUnit Â· .NET 8 | 7 tests | 0 | PASS |
| 4 | End-to-End UI Tests | Playwright Â· JavaScript | 11 tests | 0 | PASS |
| 5 | REST API Tests | Mocha Â· Chai Â· Chai HTTP | 5 tests | 0 | PASS |
| 6 | Integration Tests | xUnit Â· NUnit Â· EF Core Â· .NET 8 | 24 tests | 0 | âœ… PASS |
|  | **Verified total** | **Multiple testing frameworks** | **76 checks** | **0** | **ALL PASSED** |

> The total uses the word **checks** because it combines Postman assertions with executable tests from the other frameworks.

## Compatibility Improvements

| Original issue | Implemented solution |
|---|---|
| Projects targeted the unsupported `.NET 6` framework | Migrated all related projects to `.NET 8` |
| ChromeDriver 125/126 was incompatible with the installed browser | Removed the pinned driver and enabled automatic driver management through Selenium Manager |
| The hosted Number Calculator was unavailable | Added a compatible local test fixture preserving the original selectors and behavior |
| Strict Postman property assertion failed when the API returned extra fields | Replaced `all.keys()` with `include.all.keys()` |
| Selenium IDE was unavailable in Chromium extension stores | Used the supported Firefox extension and the exported C# project |
| Generated dependencies and test artifacts polluted the repository | Added an appropriate `.gitignore` configuration |

##  Execution Screenshots

### Selenium WebDriver â€” 7 passed

![Selenium WebDriver tests](docs/screenshots/selenium-webdriver/selenium-webdriver-7-tests-passed.png)

### Playwright â€” 11 passed

![Playwright tests](docs/screenshots/playwright/playwright-library-11-tests-passed.png)

### Mocha and Chai API â€” 5 passed

![Mocha and Chai API tests](docs/screenshots/mocha-chai/mocha-chai-books-api-5-tests-passed.png)

### xUnit and NUnit Integration Tests â€” 24 passed

![Integration tests](docs/screenshots/integration-tests/integration-tests-xunit-nunit-24-passed.png)

## ðŸ” Security Note

The committed Postman environment uses placeholder values:

```json
"trelloKey": "your-key",
"trelloToken": "your-token"
```

Real API keys and tokens must never be committed to source control.

---

<div align="center">

Animation: [Evil Hacker by Avila on Dribbble](https://dribbble.com/shots/4032985-Evil-Hacker)

</div>