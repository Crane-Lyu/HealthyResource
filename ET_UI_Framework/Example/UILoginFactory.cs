using System;
using ETModel;
using UnityEngine;

namespace ETHotfix
{
    [UIFactory(UIType_Z.UILogin)]
    public class UILoginFactory : IUIFactory_Z
    {
        public UI_Z Create(Scene scene, string type, GameObject parent)
        {
            try
            {
                ResourcesComponent resourcesComponent = Game.Scene.GetComponent<ResourcesComponent>();
                resourcesComponent.LoadBundle($"{type}.unity3d");
                GameObject bundleGameObject = resourcesComponent.GetAsset<GameObject>($"{type}.unity3d", $"{type}");
                GameObject newUi = UnityEngine.Object.Instantiate(bundleGameObject);
                newUi.layer = LayerMask.NameToLayer(LayerNames.UI);
                UI_Z ui = ComponentFactory.Create<UI_Z, GameObject>(newUi);

                //�˴����ʹ��AddUiComponent����ԭ��et�е�AddComponent����UI_Z�е�UiComponent���Ի�Ϊ��
                ui.AddUiComponent<UILoginComponent>();
                return ui;
            }
            catch (Exception e)
            {
                Log.Error(e.ToStr());
                return null;
            }
        }

        public void Remove(string type)
        {
            Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle($"{type}.unity3d");
        }
    }
}
