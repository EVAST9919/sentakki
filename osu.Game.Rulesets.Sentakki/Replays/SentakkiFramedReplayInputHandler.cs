﻿using osu.Framework.Input.StateChanges;
using osu.Framework.Utils;
using osu.Game.Replays;
using osu.Game.Rulesets.Replays;
using osuTK;
using System.Collections.Generic;
using System.Diagnostics;

namespace osu.Game.Rulesets.Sentakki.Replays
{
    public class SentakkiFramedReplayInputHandler : FramedReplayInputHandler<SentakkiReplayFrame>
    {
        public SentakkiFramedReplayInputHandler(Replay replay)
            : base(replay)
        {
        }

        protected override bool IsImportant(SentakkiReplayFrame frame) => true;

        protected Vector2 Position
        {
            get
            {
                var frame = CurrentFrame;

                if (frame == null)
                    return Vector2.Zero;

                Debug.Assert(CurrentTime != null);

                return NextFrame != null ? Interpolation.ValueAt(CurrentTime.Value, frame.Position, NextFrame.Position, frame.Time, NextFrame.Time) : frame.Position;
            }
        }

        public override void CollectPendingInputs(List<IInput> inputs)
        {
            inputs.Add(new MousePositionAbsoluteInput
            {
                Position = GamefieldToScreenSpace(Position),
            });
            inputs.Add(new ReplayState<SentakkiAction>
            {
                PressedActions = CurrentFrame?.Actions ?? new List<SentakkiAction>(),
            });
        }
    }
}
