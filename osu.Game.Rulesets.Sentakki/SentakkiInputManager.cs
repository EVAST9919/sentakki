﻿using osu.Framework.Input.Bindings;
using osu.Framework.Input.Events;
using osu.Game.Rulesets.UI;
using System.Collections.Generic;
using System.ComponentModel;

namespace osu.Game.Rulesets.Sentakki
{
    public class SentakkiInputManager : RulesetInputManager<SentakkiAction>
    {
        public bool AllowUserPresses
        {
            set => ((SentakkiKeyBindingContainer)KeyBindingContainer).AllowUserPresses = value;
        }

        protected override KeyBindingContainer<SentakkiAction> CreateKeyBindingContainer(RulesetInfo ruleset, int variant, SimultaneousBindingMode unique)
            => new SentakkiKeyBindingContainer(ruleset, variant, unique);

        private class SentakkiKeyBindingContainer : RulesetKeyBindingContainer
        {
            public bool AllowUserPresses = true;

            public SentakkiKeyBindingContainer(RulesetInfo ruleset, int variant, SimultaneousBindingMode unique)
                : base(ruleset, variant, unique)
            {
            }

            protected override bool Handle(UIEvent e)
            {
                if (!AllowUserPresses) return false;

                return base.Handle(e);
            }
        }

        public IEnumerable<SentakkiAction> PressedActions => KeyBindingContainer.PressedActions;

        public SentakkiInputManager(RulesetInfo ruleset)
            : base(ruleset, 0, SimultaneousBindingMode.Unique)
        {
        }

        public List<int> CurrentPath = new List<int>();
    }

    public enum SentakkiAction
    {
        [Description("Button 1")]
        Button1,

        [Description("Button 2")]
        Button2,
    }
}
