using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
    public class Skins : Data
    {
        public Skins(Row row, DataTable datatable) : base(row, datatable)
        {
            LoadData(this, GetType(), row);
        }

        public string Name { get; set; }

        public string Character { get; set; }

        public bool IsDefaultSkin { get; set; }

        public bool EnabledByCalendar { get; set; }

        public string TID { get; set; }

        public string Geometry { get; set; }

        public string Texture { get; set; }

        public string NormalMap { get; set; }

        public string Animation { get; set; }

        public string AltAnimation { get; set; }

        public int CameraDistance { get; set; }

        public int ViewportWidth { get; set; }

        public int ViewportHeight { get; set; }

        public string CelebrateSfx { get; set; }

        public int CelebrateSfxVolume { get; set; }

        public string DeployEffect { get; set; }

        public string AttackEffect { get; set; }

        public string AttackEffectAlt { get; set; }

        public string DieEffect { get; set; }

        public string AbilityTriggerEffect { get; set; }

        public string SkinChangeEffect { get; set; }

        public string ParticleEffect3D { get; set; }

        public string GunBone { get; set; }
    }
}
