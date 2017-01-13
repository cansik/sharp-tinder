using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
	public class Globals
	{

		[JsonProperty("boost_down")]
		public int BoostDown { get; set; }

		[JsonProperty("fetch_connections")]
		public bool FetchConnections { get; set; }

		[JsonProperty("tinder_sparks")]
		public bool TinderSparks { get; set; }

		[JsonProperty("matchmaker_default_message")]
		public string MatchmakerDefaultMessage { get; set; }

		[JsonProperty("share_default_text")]
		public string ShareDefaultText { get; set; }

		[JsonProperty("recs_interval")]
		public int RecsInterval { get; set; }

		[JsonProperty("sparks_enabled")]
		public bool SparksEnabled { get; set; }

		[JsonProperty("moments_interval")]
		public int MomentsInterval { get; set; }

		[JsonProperty("sparks")]
		public bool Sparks { get; set; }

		[JsonProperty("updates_interval")]
		public int UpdatesInterval { get; set; }

		[JsonProperty("invite_type")]
		public string InviteType { get; set; }

		[JsonProperty("kontagent_enabled")]
		public bool KontagentEnabled { get; set; }

		[JsonProperty("boost_up")]
		public int BoostUp { get; set; }

		[JsonProperty("friends")]
		public bool Friends { get; set; }

		[JsonProperty("boost_decay")]
		public int BoostDecay { get; set; }

		[JsonProperty("kontagent")]
		public bool Kontagent { get; set; }

		[JsonProperty("recs_size")]
		public int RecsSize { get; set; }

		[JsonProperty("mqtt")]
		public bool Mqtt { get; set; }

		[JsonProperty("plus")]
		public bool Plus { get; set; }
	}

	public class Versions
	{

		[JsonProperty("trending")]
		public string Trending { get; set; }

		[JsonProperty("matchmaker")]
		public string Matchmaker { get; set; }

		[JsonProperty("trending_active_text")]
		public string TrendingActiveText { get; set; }

		[JsonProperty("age_filter")]
		public string AgeFilter { get; set; }

		[JsonProperty("active_text")]
		public string ActiveText { get; set; }
	}

	public class ProfileSchool
	{

		[JsonProperty("displayed")]
		public bool Displayed { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("year")]
		public string Year { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}

	public class ProcessedFile
	{

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("height")]
		public int Height { get; set; }
	}

	public class InformationPhoto
	{

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("fbId")]
		public string FbId { get; set; }

		[JsonProperty("fileName")]
		public string FileName { get; set; }

		[JsonProperty("processedFiles")]
		public IList<ProcessedFile> ProcessedFiles { get; set; }

		[JsonProperty("extension")]
		public string Extension { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("xoffset_percent")]
		public double? XoffsetPercent { get; set; }

		[JsonProperty("ydistance_percent")]
		public double? YdistancePercent { get; set; }

		[JsonProperty("yoffset_percent")]
		public double? YoffsetPercent { get; set; }

		[JsonProperty("main")]
		public bool? Main { get; set; }

		[JsonProperty("xdistance_percent")]
		public double? XdistancePercent { get; set; }
	}

	public class CategoryList
	{

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class Interest
	{

		[JsonProperty("category_list")]
		public IList<CategoryList> CategoryList { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("category")]
		public string Category { get; set; }

		[JsonProperty("created_time")]
		public DateTime CreatedTime { get; set; }
	}

	public class ProfileCompany
	{

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("displayed")]
		public bool Displayed { get; set; }
	}

	public class ProfileJob
	{

		[JsonProperty("company")]
		public ProfileCompany Company { get; set; }
	}

	public class User
	{

		[JsonProperty("connection_count")]
		public int ConnectionCount { get; set; }

		[JsonProperty("age_filter_min")]
		public int AgeFilterMin { get; set; }

		[JsonProperty("can_create_squad")]
		public bool CanCreateSquad { get; set; }

		[JsonProperty("api_token")]
		public string ApiToken { get; set; }

		[JsonProperty("ping_time")]
		public DateTime PingTime { get; set; }

		[JsonProperty("birth_date")]
		public DateTime BirthDate { get; set; }

		[JsonProperty("photos_processing")]
		public bool PhotosProcessing { get; set; }

		[JsonProperty("schools")]
		public IList<ProfileSchool> Schools { get; set; }

		[JsonProperty("discoverable")]
		public bool Discoverable { get; set; }

		[JsonProperty("_id")]
		public string Id { get; set; }

		[JsonProperty("create_date")]
		public DateTime CreateDate { get; set; }

		[JsonProperty("active_time")]
		public DateTime ActiveTime { get; set; }

		[JsonProperty("purchases")]
		public IList<object> Purchases { get; set; }

		[JsonProperty("bio")]
		public string Bio { get; set; }

		[JsonProperty("is_new_user")]
		public bool IsNewUser { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("squads_only")]
		public bool SquadsOnly { get; set; }

		[JsonProperty("age_filter_max")]
		public int AgeFilterMax { get; set; }

		[JsonProperty("gender")]
		public int Gender { get; set; }

		[JsonProperty("full_name")]
		public string FullName { get; set; }

		[JsonProperty("groups")]
		public IList<string> Groups { get; set; }

		[JsonProperty("distance_filter")]
		public int DistanceFilter { get; set; }

		[JsonProperty("squads_discoverable")]
		public bool SquadsDiscoverable { get; set; }

		[JsonProperty("photos")]
		public IList<InformationPhoto> Photos { get; set; }

		[JsonProperty("gender_filter")]
		public int GenderFilter { get; set; }

		[JsonProperty("interests")]
		public IList<Interest> Interests { get; set; }

		[JsonProperty("jobs")]
		public IList<ProfileJob> Jobs { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }
	}

	public class TinderInformation
	{

		[JsonProperty("globals")]
		public Globals Globals { get; set; }

		[JsonProperty("versions")]
		public Versions Versions { get; set; }

		[JsonProperty("token")]
		public string Token { get; set; }

		[JsonProperty("user")]
		public User User { get; set; }
	}
}

