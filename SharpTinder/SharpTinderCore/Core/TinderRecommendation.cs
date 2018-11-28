using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder.Core
{
    public class Meta
    {

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class ProcessedFile
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class Photo
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("processedFiles")]
        public IList<ProcessedFile> ProcessedFiles { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("main")]
        public object Main { get; set; }

        [JsonProperty("xoffset_percent")]
        public double? XoffsetPercent { get; set; }

        [JsonProperty("yoffset_percent")]
        public double? YoffsetPercent { get; set; }

        [JsonProperty("xdistance_percent")]
        public double? XdistancePercent { get; set; }

        [JsonProperty("ydistance_percent")]
        public double? YdistancePercent { get; set; }

        [JsonProperty("shape")]
        public string Shape { get; set; }

        [JsonProperty("successRate")]
        public double? SuccessRate { get; set; }

        [JsonProperty("selectRate")]
        public double? SelectRate { get; set; }
    }

    public class Company
    {

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Title
    {

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Job
    {

        [JsonProperty("company")]
        public Company Company { get; set; }

        [JsonProperty("title")]
        public Title Title { get; set; }
    }

    public class School
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class User
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photos")]
        public IList<Photo> Photos { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("jobs")]
        public IList<Job> Jobs { get; set; }

        [JsonProperty("schools")]
        public IList<School> Schools { get; set; }

        [JsonProperty("show_gender_on_profile")]
        public bool ShowGenderOnProfile { get; set; }

        [JsonProperty("is_traveling")]
        public bool? IsTraveling { get; set; }

        [JsonProperty("hide_distance")]
        public bool? HideDistance { get; set; }

        [JsonProperty("hide_age")]
        public bool? HideAge { get; set; }
    }

    public class CommonInterest
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Facebook
    {

        [JsonProperty("common_connections")]
        public IList<object> CommonConnections { get; set; }

        [JsonProperty("connection_count")]
        public int ConnectionCount { get; set; }

        [JsonProperty("common_interests")]
        public IList<CommonInterest> CommonInterests { get; set; }
    }

    public class Image
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Album
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("images")]
        public IList<Image> Images { get; set; }
    }

    public class Artist
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SpotifyThemeTrack
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("album")]
        public Album Album { get; set; }

        [JsonProperty("artists")]
        public IList<Artist> Artists { get; set; }
    }

    public class Spotify
    {

        [JsonProperty("spotify_connected")]
        public bool SpotifyConnected { get; set; }

        [JsonProperty("spotify_theme_track")]
        public SpotifyThemeTrack SpotifyThemeTrack { get; set; }
    }

    public class Teaser
    {

        [JsonProperty("string")]
        public string String { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class InstaramPhoto
    {

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("ts")]
        public string Ts { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Instagram
    {

        [JsonProperty("last_fetch_time")]
        public DateTime LastFetchTime { get; set; }

        [JsonProperty("completed_initial_fetch")]
        public bool CompletedInitialFetch { get; set; }

        [JsonProperty("photos")]
        public IList<InstaramPhoto> Photos { get; set; }

        [JsonProperty("media_count")]
        public int MediaCount { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class Result
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("facebook")]
        public Facebook Facebook { get; set; }

        [JsonProperty("spotify")]
        public Spotify Spotify { get; set; }

        [JsonProperty("distance_mi")]
        public int DistanceMi { get; set; }

        [JsonProperty("content_hash")]
        public string ContentHash { get; set; }

        [JsonProperty("s_number")]
        public int SNumber { get; set; }

        [JsonProperty("teaser")]
        public Teaser Teaser { get; set; }

        [JsonProperty("teasers")]
        public IList<Teaser> Teasers { get; set; }

        [JsonProperty("instagram")]
        public Instagram Instagram { get; set; }
    }

    public class Data
    {

        [JsonProperty("results")]
        public IList<Result> Results { get; set; }
    }

    public class TinderRecommendation
    {

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
