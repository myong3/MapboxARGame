namespace Mapbox.Unity.Map
{
	using System;
	using System.Collections.Generic;
	using Mapbox.Unity.MeshGeneration.Modifiers;
	using Mapbox.Unity.Utilities;
	using UnityEngine;

	[Serializable]
	public class VectorSubLayerProperties : LayerProperties
	{
		public CoreVectorLayerProperties coreOptions = new CoreVectorLayerProperties();
		public VectorFilterOptions filterOptions = new VectorFilterOptions();
		public GeometryExtrusionOptions extrusionOptions = new GeometryExtrusionOptions
		{
			extrusionType = ExtrusionType.None,
			propertyName = "height",
			extrusionGeometryType = ExtrusionGeometryType.RoofAndSide,

		};
		public ColliderOptions colliderOptions = new ColliderOptions
		{
			colliderType = ColliderType.None,
		};

		public GeometryMaterialOptions materialOptions = new GeometryMaterialOptions();

		public LayerPerformanceOptions performanceOptions;

		//HACK : workaround to avoid users accidentaly leaving the buildingsWithUniqueIds settign on and have missing buildings. 
		public bool honorBuildingIdSetting = true;
		public bool buildingsWithUniqueIds = false;

		public PositionTargetType moveFeaturePositionTo;
		[NodeEditorElement("Mesh Modifiers")]
		public List<MeshModifier> MeshModifiers;
		[NodeEditorElement("Game Object Modifiers")]
		public List<GameObjectModifier> GoModifiers;
		public PresetFeatureType presetFeatureType = PresetFeatureType.Custom;

		//public string roadLayer = "road";
		//public string landuseLayer = "landuse";
		//public string roadLayer_TypeProperty = "class";
		//public string landuseLayer_TypeProperty = "class";

		[SerializeField]
		private int _maskValue;

		public string selectedTypes;
	}

}
