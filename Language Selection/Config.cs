//paste in "public class Config : Configurable<Config>"
public enum Language
{
    English,
    German
    //you can add more here
}

[Category("Language")]
[DisplayName("Mod Language")]
[Description("Changes the Language of the Mod")]
[DefaultValue("English")]
public Language ModCPKLanguage { get; set; } = Language.English;