# Alphabetical Word Sorter API

A high-performance .NET 8 Web API designed to receive a string via a webhook, sort its characters alphabetically, and return them as a JSON array.

## 🚀 Features
- **Endpoint:** POST `/` processes string inputs into sorted character arrays.
- **Frontend Bonus:** Includes an interactive UI served via static files.
- **Architecture:** Built using ASP.NET Core MVC with a clean, scalable structure.
- **Deployment:** Fully containerized and hosted on Railway.

## 🛠️ Tech Stack
- **Backend:** C# / .NET 8
- **Frontend:** HTML5 / CSS3 / JavaScript (Vanilla)

## 🧪 Testing the API
To test the endpoint manually, send a POST request to the root URL:
**Payload:**
{ "string": "zebra" }

**Response:**
{ "word": ["a", "b", "e", "r", "z"] }
