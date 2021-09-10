using System;
using System.Text.Json.Serialization;

namespace dotnet_httpclient.test
{
  internal record GitHubResponse(
    [property: JsonPropertyName("current_user_url")]
    Uri CurrentUserUrl,

    [property: JsonPropertyName("current_user_authorizations_html_url")]
    string CurrentUserAuthorizationsHtmlUrl,

    [property: JsonPropertyName("authorizations_url")]
    Uri AuthorizationsUrl,

    [property: JsonPropertyName("code_search_url")]
    string CodeSearchUrl,

    [property: JsonPropertyName("commit_search_url")]
    string CommitSearchUrl,

    [property: JsonPropertyName("emails_url")]
    Uri EmailsUrl,

    [property: JsonPropertyName("emojis_url")]
    Uri EmojisUrl,

    [property: JsonPropertyName("events_url")]
    Uri EventsUrl,

    [property: JsonPropertyName("feeds_url")]
    Uri FeedsUrl,

    [property: JsonPropertyName("followers_url")]
    Uri FollowersUrl,

    [property: JsonPropertyName("following_url")]
    string FollowingUrl,

    [property: JsonPropertyName("gists_url")]
    string GistsUrl,

    [property: JsonPropertyName("hub_url")]
    Uri HubUrl,

    [property: JsonPropertyName("issue_search_url")]
    string IssueSearchUrl,

    [property: JsonPropertyName("issues_url")]
    Uri IssuesUrl,

    [property: JsonPropertyName("keys_url")]
    Uri KeysUrl,

    [property: JsonPropertyName("label_search_url")]
    string LabelSearchUrl,

    [property: JsonPropertyName("notifications_url")]
    Uri NotificationsUrl,

    [property: JsonPropertyName("organization_url")]
    string OrganizationUrl,

    [property: JsonPropertyName("organization_repositories_url")]
    string OrganizationRepositoriesUrl,

    [property: JsonPropertyName("organization_teams_url")]
    string OrganizationTeamsUrl,

    [property: JsonPropertyName("public_gists_url")]
    Uri PublicGistsUrl,

    [property: JsonPropertyName("rate_limit_url")]
    Uri RateLimitUrl,

    [property: JsonPropertyName("repository_url")]
    string RepositoryUrl,

    [property: JsonPropertyName("repository_search_url")]
    string RepositorySearchUrl,

    [property: JsonPropertyName("current_user_repositories_url")]
    string CurrentUserRepositoriesUrl,

    [property: JsonPropertyName("starred_url")]
    string StarredUrl,

    [property: JsonPropertyName("starred_gists_url")]
    Uri StarredGistsUrl,

    [property: JsonPropertyName("user_url")]
    string UserUrl,

    [property: JsonPropertyName("user_organizations_url")]
    Uri UserOrganizationsUrl,

    [property: JsonPropertyName("user_repositories_url")]
    string UserRepositoriesUrl,

    [property: JsonPropertyName("user_search_url")]
    string UserSearchUrl
  );
}
