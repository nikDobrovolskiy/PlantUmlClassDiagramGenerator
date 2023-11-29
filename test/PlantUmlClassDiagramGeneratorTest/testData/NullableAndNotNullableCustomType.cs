namespace PlantUmlClassDiagramGeneratorTest
{
    public class NullableAndNotNullableCustomType
    {
        public CustomType NotNullableCustomType { get; set; }
        public CustomType? NullableCustomType { get; set; }
    }

    public class CustomType
    {
        public string Name { get; set; }
    }
}