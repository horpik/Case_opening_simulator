using Resources.Scripts.AllData;

namespace Resources.Scripts.Items
{
    public class ListElementRouletteItem : ListElement
    {
        private IItem myItem;
        public void SetItem(IItem _item) => myItem = _item;
        public IItem GetItem() => myItem;
    }
}