# 📊 WordCountAPI (.NET 8)

A clean and modular ASP.NET Core Web API project that counts the frequency of words in a text file and returns the result sorted by occurrence.

Built using **.NET 8** and **N-Tier Architecture** to ensure high maintainability, testability, and extensibility.

---

## ✅ Features

- Upload `.txt` files via `POST /api/wordcount`
- Count all **alphanumeric words** (case-insensitive)
- Return results sorted **by frequency (desc)**
- Handles file validation and common error cases
- Fully compatible with **.NET 8 minimal hosting model**

---

## 🧱 Project Structure

```
WordCountAPI/
├── Controllers/
│   └── WordCountController.cs
│
├── Services/
│   ├── IWordCountService.cs
│   └── WordCountService.cs
│
├── Models/
│   ├── WordCountResult.cs
│   └── WordCountRequest.cs
│
├── Utilities/
│   └── WordParser.cs
│
└── Program.cs
```


---

## 🚀 Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022+, Rider, or VS Code

### Run Locally

```bash
dotnet build
dotnet run


Open in browser:
https://localhost:{PORT}/swagger

---

---
📮 API Endpoint
POST /api/wordcount
Method: POST

Content-Type: multipart/form-data

Form Field: file (Only .txt files allowed)

---

---
✅ Example Response

[
  {
    "word": "lorem",
    "count": 8
  },
  {
    "word": "ipsum",
    "count": 6
  },
  {
    "word": "dolor",
    "count": 4
  }
]

---

---
🔍 Word Processing Rules
✅ Only .txt files are accepted

✅ Words are case-insensitive

✅ Only alphanumeric characters (a-z, A-Z, 0-9)

✅ Words are separated by whitespace

✅ Punctuation is ignored

---

---
⚠️ Error Handling
| Scenario               | Error Message                   |
| ---------------------- | ------------------------------- |
| No file uploaded       | `No file uploaded.`             |
| Empty file             | `File is empty or null.`        |
| Invalid file extension | `Only .txt files are allowed.`  |
| Internal server error  | `An unexpected error occurred.` |
---

---
🧪 Manual Test Cases Covered
Mixed case handling (Word, word, WORD)

Repeated words counted correctly

Punctuation and special characters ignored

Large files tested

Empty file / missing file tested
---


---
🛠️ Tech Stack
ASP.NET Core 8 Web API

N-Tier Architecture (Controller, Service, Utility, Model)

Regex-based word parsing

Dependency Injection

---

---
👤 Author
Ulvi Poladov

---

Swagger (OpenAPI)
