using UnityEngine;
using UnityEngine.UIElements;

namespace UitkForKsp2.Controls
{
    [UxmlElement]
    public partial class Ksp2Dropdown : DropdownField
    {
        private VisualElement _dropdownBackground;
        private VisualElement _dropdownBorder;
        private VisualElement _popUpTextElement;
        private VisualElement _dropdownArrows;
        
        public Ksp2Dropdown()
        {
            _dropdownBackground = CreateVisualElement("ksp2-dropdown-background");
            _dropdownBorder = CreateVisualElement("ksp2-dropdown-border");
            BuildVisualTree();
        }
        
        private static VisualElement CreateVisualElement(string className)
        {
            var container = new VisualElement();
            container.AddToClassList(className);
            return container;
        }

        private void BuildVisualTree()
        {
            Clear();
            AddToClassList("ksp2-dropdown");
            hierarchy.Add(_dropdownBackground);
            _dropdownBackground.Add(_dropdownBorder);
        }
    }
}
