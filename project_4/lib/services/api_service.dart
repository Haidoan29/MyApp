import 'dart:convert';
import 'package:http/http.dart' as http;


class ApiService {
  final String apiUrl = "https://103.179.190.105:5001/api/Auth"; // Địa chỉ IP cục bộ của máy chủ

  Future<Map<String, dynamic>> login(String username, String password) async {
    final response = await http.post(
      Uri.parse(apiUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
      },
      body: jsonEncode(<String, String>{
        'username': username,
        'password': password,
      }),
    );https://10.0.2.69:5001/swagger/index.html
    if (response.statusCode == 200) {
      return jsonDecode(response.body);
    } else {
      throw Exception('Failed to login');
    }
  }
}
