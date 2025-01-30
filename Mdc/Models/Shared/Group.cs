using System;
using System.Collections.Generic;
using System.Text;

namespace Behnammby.Mdc.Models.Shared
{
    public class Group
    {
        public string Name { get; set; }
        public IEnumerable<Item> Items { get; set; }
        public bool ShowGrphics { get; set; }

        public static IEnumerable<Group> CreateSingle(IEnumerable<Item> items, bool showGraphics)
        {
            yield return new Group
            {
                Name = nameof(Group),
                Items = items,
                ShowGrphics = showGraphics
            };
        }
    }
}
