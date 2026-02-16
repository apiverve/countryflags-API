# Country Flags API - Dart/Flutter Client

Country Flag is a simple tool for getting the country's national flags. It returns the country's national flags.

[![pub package](https://img.shields.io/pub/v/apiverve_countryflags.svg)](https://pub.dev/packages/apiverve_countryflags)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This is the Dart/Flutter client for the [Country Flags API](https://apiverve.com/marketplace/countryflags?utm_source=dart&utm_medium=readme).

## Installation

Add this to your `pubspec.yaml`:

```yaml
dependencies:
  apiverve_countryflags: ^1.1.14
```

Then run:

```bash
dart pub get
# or for Flutter
flutter pub get
```

## Usage

```dart
import 'package:apiverve_countryflags/apiverve_countryflags.dart';

void main() async {
  final client = CountryflagsClient('YOUR_API_KEY');

  try {
    final response = await client.execute({
      'country': 'ZW',
      'format': 'png',
      'shape': 'circle'
    });

    print('Status: ${response.status}');
    print('Data: ${response.data}');
  } catch (e) {
    print('Error: $e');
  }
}
```

## Response

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

## API Reference

- **API Home:** [Country Flags API](https://apiverve.com/marketplace/countryflags?utm_source=dart&utm_medium=readme)
- **Documentation:** [docs.apiverve.com/ref/countryflags](https://docs.apiverve.com/ref/countryflags?utm_source=dart&utm_medium=readme)

## Authentication

All requests require an API key. Get yours at [apiverve.com](https://apiverve.com?utm_source=dart&utm_medium=readme).

## License

MIT License - see [LICENSE](LICENSE) for details.

---

Built with Dart for [APIVerve](https://apiverve.com?utm_source=dart&utm_medium=readme)
