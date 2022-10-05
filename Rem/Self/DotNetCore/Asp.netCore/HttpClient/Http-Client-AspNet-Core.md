var response = await httpClient.GetAsync(url);
response.EnsureSuccessState();
response.Content.ReadAsStringAsync();
