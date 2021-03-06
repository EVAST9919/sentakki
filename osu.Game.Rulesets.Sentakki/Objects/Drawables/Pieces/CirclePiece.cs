﻿using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osuTK;
using osuTK.Graphics;

namespace osu.Game.Rulesets.Sentakki.Objects.Drawables.Pieces
{
    public class CirclePiece : CircularContainer
    {
        public CirclePiece()
        {
            RelativeSizeAxes = Axes.Both;
            Size = new Vector2(1f);
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;

            Children = new Drawable[]
            {
                new CircularContainer
                {
                    RelativeSizeAxes = Axes.Both,
                    Masking = true,
                    BorderThickness = 17.35f,
                    BorderColour = Color4.Gray,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Child = new Box
                    {
                        RelativeSizeAxes = Axes.Both,
                        Alpha= 0,
                        AlwaysPresent = true
                    }
                },
                new CircularContainer
                {
                    Masking = true,
                    RelativeSizeAxes = Axes.Both,
                    Padding = new MarginPadding(1),
                    Child = new CircularContainer
                    {
                        RelativeSizeAxes = Axes.Both,
                        Masking = true,
                        BorderThickness = 15,
                        BorderColour = Color4.White,
                        Child = new Box
                        {
                            RelativeSizeAxes = Axes.Both,
                            Alpha = 0,
                            AlwaysPresent = true,
                        }
                    }
                },
                new CircularContainer
                {
                    RelativeSizeAxes = Axes.Both,
                    Masking = true,
                    BorderThickness = 2,
                    BorderColour = Color4.Gray,
                    Child = new Box
                    {
                        RelativeSizeAxes = Axes.Both,
                        Alpha= 0,
                        AlwaysPresent = true
                    }
                },
                new CircularContainer
                {
                    Size = new Vector2(20),
                    Masking = true,
                    BorderColour = Color4.Gray,
                    BorderThickness = 2,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Child = new Box
                    {
                        RelativeSizeAxes = Axes.Both,
                        AlwaysPresent = true,
                        Colour = Color4.White,
                    }
                }
            };
        }
    }
}
