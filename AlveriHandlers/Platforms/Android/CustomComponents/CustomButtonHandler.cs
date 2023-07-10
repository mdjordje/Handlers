using System;
using Google.Android.Material.Button;
using Microsoft.Maui.Handlers;
using static Android.Provider.MediaStore;

namespace AlveriHandlers.CustomComponents
{
    //partial class CustomButtonHandler : ViewHandler<CustomButton, Android.Widget.Button>

    //{
    //    protected override Android.Widget.Button CreatePlatformView()
    //    {
    //        var platformView = new Android.Widget.Button(Context, null, Android.Resource.Attribute.Button);

    //        return platformView;
    //    }

    //    protected override void ConnectHandler(Android.Widget.Button platformView)
    //    {
    //        base.ConnectHandler(platformView);
    //        platformView.Gravity = Android.Views.GravityFlags.Center | Android.Views.GravityFlags.CenterVertical;
    //        platformView.SetAllCaps(false);
    //    }

    //    protected override void DisconnectHandler(Android.Widget.Button platformView)
    //    {
    //        platformView.Dispose();
    //        base.DisconnectHandler(platformView);
    //    }

    //    public static void MapText(CustomButtonHandler handler, CustomButton customButton)
    //    {
    //        handler.PlatformView.Text = customButton.Text;
    //    }

    //    public static IPropertyMapper<CustomButton, CustomButtonHandler> PropertyMapper = new PropertyMapper<CustomButton, CustomButtonHandler>(ViewHandler.ViewMapper)
    //    {
    //        [nameof(CustomButton.Text)] = MapText
    //    };

    //    public CustomButtonHandler() : base(PropertyMapper)
    //    {
    //    }
    //}

    partial class CustomButtonHandler : IButtonHandler
    {
        protected override Button CreatePlatformView()
        {
            return base.CreatePlatformView();
        }

        protected override void ConnectHandler(MaterialButton platformView)
        {
            base.ConnectHandler(platformView);
            platformView.Gravity = Android.Views.GravityFlags.Center | Android.Views.GravityFlags.CenterVertical;
            platformView.SetAllCaps(false);
        }

        public static IPropertyMapper<CustomButton, CustomButtonHandler> PropertyMapper = new PropertyMapper<CustomButton, CustomButtonHandler>(ViewHandler.ViewMapper)
        {
            [nameof(CustomButton.Text)] = MapText
        };

        public static void MapText(CustomButtonHandler handler, CustomButton customButton)
        {
            handler.PlatformView.Text = customButton.Text;
        }

        public CustomButtonHandler() : base(PropertyMapper)
        {
        }
    }
}

