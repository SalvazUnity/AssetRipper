﻿using AssetRipper.Assets;
using AssetRipper.Processing;

namespace AssetRipper.Export.PrimaryContent.Models;

public sealed class GlbSceneModelExportCollection : MultipleExportCollection<SceneHierarchyObject>
{
	public GlbSceneModelExportCollection(GlbModelExporter assetExporter, SceneHierarchyObject asset) : base(assetExporter, asset)
	{
		AddAssets(asset.Assets);
	}

	protected override string GetExportExtension(IUnityObjectBase asset) => "glb";
}
