﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using NaughtyAttributes.Editor;
using UnityEditor;

namespace Knight.Framework.TinyMode.UI.Editor
{
    [CustomEditor(typeof(ViewModelDataSourceArray), true)]
    public class ViewModelDataSourceArrayInspector : InspectorEditor
    {
        private ViewModelDataSourceArray mTarget;

        protected override void OnEnable()
        {
            base.OnEnable();
            mTarget = this.target as ViewModelDataSourceArray;
        }

        public override void OnInspectorGUI()
        {
            this.mTarget.GetPaths();
            base.OnInspectorGUI();

            this.serializedObject.ApplyModifiedProperties();
        }
    }
}
