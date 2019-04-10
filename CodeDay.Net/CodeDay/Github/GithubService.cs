﻿using CodeDay.Github.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace CodeDay.Github
{
  class GithubService
  {
    static string GITHUB_BASE_URL = "https://api.github.com/";
    static HttpClient client = new HttpClient();

    public static async Task<List<Repo>> GetAllUserRepos(string userName)
    {
      List<Repo> repos = null;
      string url = $"{GITHUB_BASE_URL}users/{userName}/repos";
      HttpResponseMessage response = await client.GetAsync(url);
      if (response.IsSuccessStatusCode)
      {
        repos = await response.Content.ReadAsAsync<List<Repo>>();
      }

      return repos;
    }

  }
}