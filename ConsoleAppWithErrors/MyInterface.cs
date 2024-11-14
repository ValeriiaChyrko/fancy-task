using System;

namespace HomeworkAssignment
{
    // Порушення правила: "dotnet_naming_rule.interface_should_be_begins_with_i"
    public interface MyInterface // Інтерфейс не починається з "I"
    {
        // Порушення правила: "dotnet_style_prefer_auto_properties = true"
        public string Name; // Використання поля замість авто-властивості

        // Порушення правила: "csharp_style_var_for_built_in_types = false"
        public void MyMethod()
        {
            var number = 42; // Використання var для базового типу
        }

        // Порушення правила: "csharp_style_expression_bodied_methods = false"
        public int Add(int a, int b) => a + b; // Використання виразу для методу, хоча це не дозволено

        // Порушення правила: "dotnet_style_qualification_for_property = false"
        public string GetName() => this.Name; // Використання "this." для доступу до властивості, хоча це не дозволено
    }
}