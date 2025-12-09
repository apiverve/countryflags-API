# Country Flags API

Country Flag is a simple tool for getting the country's national flags. It returns the country's national flags.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a Javascript Wrapper for the [Country Flags API](https://apiverve.com/marketplace/countryflags)

---

## Installation

Using npm:
```shell
npm install @apiverve/countryflags
```

Using yarn:
```shell
yarn add @apiverve/countryflags
```

---

## Configuration

Before using the Country Flags API client, you have to setup your account and obtain your API Key.
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Quick Start

[Get started with the Quick Start Guide](https://docs.apiverve.com/quickstart)

The Country Flags API documentation is found here: [https://docs.apiverve.com/ref/countryflags](https://docs.apiverve.com/ref/countryflags).
You can find parameters, example responses, and status codes documented here.

### Setup

```javascript
const countryflagsAPI = require('@apiverve/countryflags');
const api = new countryflagsAPI({
    api_key: '[YOUR_API_KEY]'
});
```

---

## Usage

---

### Perform Request

Using the API is simple. All you have to do is make a request. The API will return a response with the data you requested.

```javascript
var query = {
  country: "ZW",
  format: "png",
  shape: "circle"
};

api.execute(query, function (error, data) {
    if (error) {
        return console.error(error);
    } else {
        console.log(data);
    }
});
```

---

### Using Promises

You can also use promises to make requests. The API returns a promise that you can use to handle the response.

```javascript
var query = {
  country: "ZW",
  format: "png",
  shape: "circle"
};

api.execute(query)
    .then(data => {
        console.log(data);
    })
    .catch(error => {
        console.error(error);
    });
```

---

### Using Async/Await

You can also use async/await to make requests. The API returns a promise that you can use to handle the response.

```javascript
async function makeRequest() {
    var query = {
  country: "ZW",
  format: "png",
  shape: "circle"
};

    try {
        const data = await api.execute(query);
        console.log(data);
    } catch (error) {
        console.error(error);
    }
}
```

---

## Example Response

```json
{
  "status": "ok",
  "error": null,
  "data": {
    "country": "Zimbabwe",
    "countryCode": "ZW",
    "shape": "circle",
    "format": "png",
    "downloadUrl": "https://storage.googleapis.com/apiverve.appspot.com/APIResources/countryflags/circle/png/zw.png?GoogleAccessId=635500398038-compute%40developer.gserviceaccount.com&Expires=1740259794&Signature=KayVZkDE4ScEXvYM%2BSveuHPTNbsxAdtUJSKN4S9pCVEaWDBkhSZYX6P0xS3TcTeHuiaetBYgmSj7FvkaDinjFzNtjpxmUd8n%2FoAdvUK%2BIeANBKkw%2B2QMquwpHcMeZPwAiV%2BRbbGU8b1V%2FxtXdiTzkOMWLm%2Bmfipwp4%2FQ5nL8Gr637kj6F5FRPzIJVakORdrE6rWfUCwP4rfiXYZMVLN4zHMZaZb44y8AoFaavt6UAS0wAnaav0XDWjV8OjXC1Oq99DYIJA%2FrvPQHYwBZWBTxMdZ8OSC%2BA2rIinlDaeTj4IrQqsd4AAfAWEs1ESAox0QJcKCXs4mYrJdZLMlN3JEAAA%3D%3D"
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates

Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
