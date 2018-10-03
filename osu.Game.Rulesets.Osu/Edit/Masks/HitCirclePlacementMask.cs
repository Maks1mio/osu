// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Graphics;
using osu.Framework.Input.Events;
using osu.Game.Rulesets.Edit;
using osu.Game.Rulesets.Osu.Objects;

namespace osu.Game.Rulesets.Osu.Edit.Masks
{
    public class HitCirclePlacementMask : PlacementMask
    {
        public new HitCircle HitObject => (HitCircle)base.HitObject;

        public HitCirclePlacementMask()
            : base(new HitCircle())
        {
            Origin = Anchor.Centre;
            AutoSizeAxes = Axes.Both;

            InternalChild = new HitCircleMask(HitObject);
        }

        protected override bool OnClick(ClickEvent e)
        {
            Finish();
            return true;
        }

        protected override bool OnMouseMove(MouseMoveEvent e)
        {
            HitObject.Position = e.MousePosition;
            return base.OnMouseMove(e);
        }
    }
}
