using Newtonsoft.Json;

namespace MyRecipeStorage.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Category
    {
        [JsonProperty(PropertyName="categoryname")]
        public string CategoryName { get; set; }
    }
}