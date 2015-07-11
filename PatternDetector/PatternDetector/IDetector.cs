using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using SharpDX;

namespace PatternDetector
{
    public enum DetectorSetting { VFX01, VFX02, VFX03}
    interface IDetector
    {
        void Initialize(Obj_AI_Hero hero, DetectorSetting setting = DetectorSetting.VFX02);
        void ApplySetting(DetectorSetting setting);
        void FeedData(Vector3 targetPos);
        int GetScriptDetections();
        string GetName();
    }
}
