﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osuTK;

namespace osu.Game.Rulesets.Maimai.Objects.Drawables.Pieces
{
    public class ExplodePiece : Container
    {
        public ExplodePiece()
        {
            RelativeSizeAxes = Axes.Both;
            Size = new Vector2(1f);

            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;

            Blending = BlendingParameters.Additive;
            Alpha = 0;

            Child = new TrianglesPiece
            {
                Blending = BlendingParameters.Additive,
                RelativeSizeAxes = Axes.Both,
                Alpha = 0.2f,
            };
        }
    }
}