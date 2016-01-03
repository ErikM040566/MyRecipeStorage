using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyRecipeStorage.Models
{
   [JsonObject(MemberSerialization.OptIn)]
   public class RecipeMin
    {
        [JsonProperty(PropertyName="recipeguid")]
        public string RecipeGuid { get; set; }

        [JsonProperty(PropertyName="title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName="subtitle")]
        public string SubTitle { get; set; }

        [JsonProperty(PropertyName="description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName="mainimage")]
        public string MainImage { get; set; }

        [JsonProperty(PropertyName="difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty(PropertyName = "timeestimate")]
        public string TimeEstimate { get; set; }

        [JsonProperty(PropertyName="categories")]
        public IEnumerable<Category> Categories { get; set; }
    }
}