﻿using System.Collections.Generic;
using UnityEngine;

public class ClickerScene : Scene
{
    private BackgroundViewer bgViewer;
    private AssetViewer aViewer;

    private List<ClickerSceneAsset> _assets;
    private Texture _background;

    public ClickerScene(List<ClickerSceneAsset> assets, Texture background = null)
    {
        bgViewer = BackgroundViewer.Instance;
        aViewer = AssetViewer.Instance;

        _assets = assets;
        _background = background;
    }

    public override void show()
    {
        showBackground();
        showAssets();
    }

    private void showBackground()
    {
        bgViewer.Transition(_background);
    }

    private void showAssets()
    {
        foreach (ClickerSceneAsset asset in _assets)
        {
            aViewer.placeInScene(asset);
        }
    }

    public override void hide()
    {
        aViewer.clearAssets();
    }
}