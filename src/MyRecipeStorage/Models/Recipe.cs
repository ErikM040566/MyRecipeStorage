using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyRecipeStorage.Models
{
   [JsonObject(MemberSerialization.OptIn)]
   public class Recipe
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

        [JsonProperty(PropertyName="references")]
        public IEnumerable<Reference> References { get; set; }

        [JsonProperty(PropertyName="numberofportions")]
        public int NumberOfPortions { get; set; }

        [JsonProperty(PropertyName = "allowalteringnumberofportions")]
        public bool AllowAlteringNumberOfPortions { get; set; }

        [JsonProperty(PropertyName="difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty(PropertyName = "timeestimate")]
        public string TimeEstimate { get; set; }

        [JsonProperty(PropertyName="ingredients")]
        public IEnumerable<Ingredient> Ingredients { get; set; }

        [JsonProperty(PropertyName="howtosteps")]
        public IEnumerable<HowToStep> HowToSteps { get; set; }

        [JsonProperty(PropertyName="categories")]
        public IEnumerable<Category> Categories { get; set; }
    }
}