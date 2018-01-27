// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by the Game Data Editor.
//
//      Changes to this file will be lost if the code is regenerated.
//
//      This file was generated from this data file:
//      Assets/GameDataEditor/Resources/gde_data.txt
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections.Generic;

using GameDataEditor;

namespace GameDataEditor
{
    public class GDEHeroData : IGDEData
    {
        static string IDKey = "ID";
		int _ID;
        public int ID
        {
            get { return _ID; }
            set {
                if (_ID != value)
                {
                    _ID = value;
					GDEDataManager.SetInt(_key, IDKey, _ID);
                }
            }
        }

        static string MaxHPKey = "MaxHP";
		int _MaxHP;
        public int MaxHP
        {
            get { return _MaxHP; }
            set {
                if (_MaxHP != value)
                {
                    _MaxHP = value;
					GDEDataManager.SetInt(_key, MaxHPKey, _MaxHP);
                }
            }
        }

        static string MaxShieldValKey = "MaxShieldVal";
		int _MaxShieldVal;
        public int MaxShieldVal
        {
            get { return _MaxShieldVal; }
            set {
                if (_MaxShieldVal != value)
                {
                    _MaxShieldVal = value;
					GDEDataManager.SetInt(_key, MaxShieldValKey, _MaxShieldVal);
                }
            }
        }

        static string ShieldRestoreVecKey = "ShieldRestoreVec";
		int _ShieldRestoreVec;
        public int ShieldRestoreVec
        {
            get { return _ShieldRestoreVec; }
            set {
                if (_ShieldRestoreVec != value)
                {
                    _ShieldRestoreVec = value;
					GDEDataManager.SetInt(_key, ShieldRestoreVecKey, _ShieldRestoreVec);
                }
            }
        }

        static string MoveVecKey = "MoveVec";
		float _MoveVec;
        public float MoveVec
        {
            get { return _MoveVec; }
            set {
                if (_MoveVec != value)
                {
                    _MoveVec = value;
					GDEDataManager.SetFloat(_key, MoveVecKey, _MoveVec);
                }
            }
        }

        static string HurtProtectKey = "HurtProtect";
		float _HurtProtect;
        public float HurtProtect
        {
            get { return _HurtProtect; }
            set {
                if (_HurtProtect != value)
                {
                    _HurtProtect = value;
					GDEDataManager.SetFloat(_key, HurtProtectKey, _HurtProtect);
                }
            }
        }

        static string MassKey = "Mass";
		float _Mass;
        public float Mass
        {
            get { return _Mass; }
            set {
                if (_Mass != value)
                {
                    _Mass = value;
					GDEDataManager.SetFloat(_key, MassKey, _Mass);
                }
            }
        }

        static string ShieldRestoreIntervalKey = "ShieldRestoreInterval";
		float _ShieldRestoreInterval;
        public float ShieldRestoreInterval
        {
            get { return _ShieldRestoreInterval; }
            set {
                if (_ShieldRestoreInterval != value)
                {
                    _ShieldRestoreInterval = value;
					GDEDataManager.SetFloat(_key, ShieldRestoreIntervalKey, _ShieldRestoreInterval);
                }
            }
        }

        static string ShieldRestoreBreakKey = "ShieldRestoreBreak";
		float _ShieldRestoreBreak;
        public float ShieldRestoreBreak
        {
            get { return _ShieldRestoreBreak; }
            set {
                if (_ShieldRestoreBreak != value)
                {
                    _ShieldRestoreBreak = value;
					GDEDataManager.SetFloat(_key, ShieldRestoreBreakKey, _ShieldRestoreBreak);
                }
            }
        }

        static string PrefabPathKey = "PrefabPath";
		string _PrefabPath;
        public string PrefabPath
        {
            get { return _PrefabPath; }
            set {
                if (_PrefabPath != value)
                {
                    _PrefabPath = value;
					GDEDataManager.SetString(_key, PrefabPathKey, _PrefabPath);
                }
            }
        }

        public GDEHeroData(string key) : base(key)
        {
            GDEDataManager.RegisterItem(this.SchemaName(), key);
        }
        public override Dictionary<string, object> SaveToDict()
		{
			var dict = new Dictionary<string, object>();
			dict.Add(GDMConstants.SchemaKey, "Hero");
			
            dict.Merge(true, ID.ToGDEDict(IDKey));
            dict.Merge(true, MaxHP.ToGDEDict(MaxHPKey));
            dict.Merge(true, MaxShieldVal.ToGDEDict(MaxShieldValKey));
            dict.Merge(true, ShieldRestoreVec.ToGDEDict(ShieldRestoreVecKey));
            dict.Merge(true, MoveVec.ToGDEDict(MoveVecKey));
            dict.Merge(true, HurtProtect.ToGDEDict(HurtProtectKey));
            dict.Merge(true, Mass.ToGDEDict(MassKey));
            dict.Merge(true, ShieldRestoreInterval.ToGDEDict(ShieldRestoreIntervalKey));
            dict.Merge(true, ShieldRestoreBreak.ToGDEDict(ShieldRestoreBreakKey));
            dict.Merge(true, PrefabPath.ToGDEDict(PrefabPathKey));
            return dict;
		}

        public override void UpdateCustomItems(bool rebuildKeyList)
        {
        }

        public override void LoadFromDict(string dataKey, Dictionary<string, object> dict)
        {
            _key = dataKey;

			if (dict == null)
				LoadFromSavedData(dataKey);
			else
			{
                dict.TryGetInt(IDKey, out _ID);
                dict.TryGetInt(MaxHPKey, out _MaxHP);
                dict.TryGetInt(MaxShieldValKey, out _MaxShieldVal);
                dict.TryGetInt(ShieldRestoreVecKey, out _ShieldRestoreVec);
                dict.TryGetFloat(MoveVecKey, out _MoveVec);
                dict.TryGetFloat(HurtProtectKey, out _HurtProtect);
                dict.TryGetFloat(MassKey, out _Mass);
                dict.TryGetFloat(ShieldRestoreIntervalKey, out _ShieldRestoreInterval);
                dict.TryGetFloat(ShieldRestoreBreakKey, out _ShieldRestoreBreak);
                dict.TryGetString(PrefabPathKey, out _PrefabPath);
                LoadFromSavedData(dataKey);
			}
		}

        public override void LoadFromSavedData(string dataKey)
		{
			_key = dataKey;
			
            _ID = GDEDataManager.GetInt(_key, IDKey, _ID);
            _MaxHP = GDEDataManager.GetInt(_key, MaxHPKey, _MaxHP);
            _MaxShieldVal = GDEDataManager.GetInt(_key, MaxShieldValKey, _MaxShieldVal);
            _ShieldRestoreVec = GDEDataManager.GetInt(_key, ShieldRestoreVecKey, _ShieldRestoreVec);
            _MoveVec = GDEDataManager.GetFloat(_key, MoveVecKey, _MoveVec);
            _HurtProtect = GDEDataManager.GetFloat(_key, HurtProtectKey, _HurtProtect);
            _Mass = GDEDataManager.GetFloat(_key, MassKey, _Mass);
            _ShieldRestoreInterval = GDEDataManager.GetFloat(_key, ShieldRestoreIntervalKey, _ShieldRestoreInterval);
            _ShieldRestoreBreak = GDEDataManager.GetFloat(_key, ShieldRestoreBreakKey, _ShieldRestoreBreak);
            _PrefabPath = GDEDataManager.GetString(_key, PrefabPathKey, _PrefabPath);
        }

        public GDEHeroData ShallowClone()
		{
			string newKey = Guid.NewGuid().ToString();
			GDEHeroData newClone = new GDEHeroData(newKey);

            newClone.ID = ID;
            newClone.MaxHP = MaxHP;
            newClone.MaxShieldVal = MaxShieldVal;
            newClone.ShieldRestoreVec = ShieldRestoreVec;
            newClone.MoveVec = MoveVec;
            newClone.HurtProtect = HurtProtect;
            newClone.Mass = Mass;
            newClone.ShieldRestoreInterval = ShieldRestoreInterval;
            newClone.ShieldRestoreBreak = ShieldRestoreBreak;
            newClone.PrefabPath = PrefabPath;

            return newClone;
		}

        public GDEHeroData DeepClone()
		{
			GDEHeroData newClone = ShallowClone();
            return newClone;
		}

        public void Reset_ID()
        {
            GDEDataManager.ResetToDefault(_key, IDKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(IDKey, out _ID);
        }

        public void Reset_MaxHP()
        {
            GDEDataManager.ResetToDefault(_key, MaxHPKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(MaxHPKey, out _MaxHP);
        }

        public void Reset_MaxShieldVal()
        {
            GDEDataManager.ResetToDefault(_key, MaxShieldValKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(MaxShieldValKey, out _MaxShieldVal);
        }

        public void Reset_ShieldRestoreVec()
        {
            GDEDataManager.ResetToDefault(_key, ShieldRestoreVecKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(ShieldRestoreVecKey, out _ShieldRestoreVec);
        }

        public void Reset_MoveVec()
        {
            GDEDataManager.ResetToDefault(_key, MoveVecKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(MoveVecKey, out _MoveVec);
        }

        public void Reset_HurtProtect()
        {
            GDEDataManager.ResetToDefault(_key, HurtProtectKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(HurtProtectKey, out _HurtProtect);
        }

        public void Reset_Mass()
        {
            GDEDataManager.ResetToDefault(_key, MassKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(MassKey, out _Mass);
        }

        public void Reset_ShieldRestoreInterval()
        {
            GDEDataManager.ResetToDefault(_key, ShieldRestoreIntervalKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(ShieldRestoreIntervalKey, out _ShieldRestoreInterval);
        }

        public void Reset_ShieldRestoreBreak()
        {
            GDEDataManager.ResetToDefault(_key, ShieldRestoreBreakKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(ShieldRestoreBreakKey, out _ShieldRestoreBreak);
        }

        public void Reset_PrefabPath()
        {
            GDEDataManager.ResetToDefault(_key, PrefabPathKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(PrefabPathKey, out _PrefabPath);
        }

        public void ResetAll()
        {
            GDEDataManager.ResetToDefault(_key, IDKey);
            GDEDataManager.ResetToDefault(_key, MoveVecKey);
            GDEDataManager.ResetToDefault(_key, MaxHPKey);
            GDEDataManager.ResetToDefault(_key, PrefabPathKey);
            GDEDataManager.ResetToDefault(_key, HurtProtectKey);
            GDEDataManager.ResetToDefault(_key, MassKey);
            GDEDataManager.ResetToDefault(_key, MaxShieldValKey);
            GDEDataManager.ResetToDefault(_key, ShieldRestoreVecKey);
            GDEDataManager.ResetToDefault(_key, ShieldRestoreIntervalKey);
            GDEDataManager.ResetToDefault(_key, ShieldRestoreBreakKey);


            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            LoadFromDict(_key, dict);
        }
    }
}