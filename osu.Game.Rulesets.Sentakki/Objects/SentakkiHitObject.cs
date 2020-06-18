﻿using osu.Game.Rulesets.Judgements;
using osu.Game.Rulesets.Sentakki.Judgements;
using osu.Game.Rulesets.Sentakki.Scoring;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.Objects;
using osuTK;
using osuTK.Graphics;
using osu.Framework.Extensions.Color4Extensions;

namespace osu.Game.Rulesets.Sentakki.Objects
{
    public abstract class SentakkiHitObject : HitObject
    {
        public override Judgement CreateJudgement() => new SentakkiJudgement();

        public virtual Color4 NoteColor { get; set; } = Color4Extensions.FromHex("ff0064");
        public virtual Vector2 EndPosition { get; set; }
        public virtual float Angle { get; set; }

        public Vector2 Position { get; set; }

        public float X => Position.X;
        public float Y => Position.Y;

        protected override HitWindows CreateHitWindows() => new SentakkiHitWindows();
    }
}
