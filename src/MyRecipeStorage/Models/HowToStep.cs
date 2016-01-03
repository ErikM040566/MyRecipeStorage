using Newtonsoft.Json;

namespace MyRecipeStorage.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class HowToStep
    {
        [JsonProperty(PropertyName="order")]
        public int Order { get; set; }

        [JsonProperty(PropertyName="title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "desc")]
        public string Desc { get; set; }

        [JsonProperty(PropertyName = "imageurl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "videourl")]
        public string VideoUrl { get; set; }
    }
}