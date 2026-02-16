/// Response models for the Country Flags API.

/// API Response wrapper.
class CountryflagsResponse {
  final String status;
  final dynamic error;
  final CountryflagsData? data;

  CountryflagsResponse({
    required this.status,
    this.error,
    this.data,
  });

  factory CountryflagsResponse.fromJson(Map<String, dynamic> json) => CountryflagsResponse(
    status: json['status'] as String? ?? '',
    error: json['error'],
    data: json['data'] != null ? CountryflagsData.fromJson(json['data']) : null,
  );

  Map<String, dynamic> toJson() => {
    'status': status,
    if (error != null) 'error': error,
    if (data != null) 'data': data,
  };
}

/// Response data for the Country Flags API.

class CountryflagsData {
  String? country;
  String? countryCode;
  String? shape;
  String? format;
  String? downloadUrl;

  CountryflagsData({
    this.country,
    this.countryCode,
    this.shape,
    this.format,
    this.downloadUrl,
  });

  factory CountryflagsData.fromJson(Map<String, dynamic> json) => CountryflagsData(
      country: json['country'],
      countryCode: json['countryCode'],
      shape: json['shape'],
      format: json['format'],
      downloadUrl: json['downloadUrl'],
    );
}

class CountryflagsRequest {
  String country;
  String format;
  String shape;

  CountryflagsRequest({
    required this.country,
    required this.format,
    required this.shape,
  });

  Map<String, dynamic> toJson() => {
      'country': country,
      'format': format,
      'shape': shape,
    };
}
