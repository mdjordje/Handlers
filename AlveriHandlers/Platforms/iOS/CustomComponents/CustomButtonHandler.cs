using System;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Handlers;
using UIKit;

namespace AlveriHandlers.CustomComponents
{
    //partial class CustomButtonHandler : ViewHandler<CustomButton, UIKit.UIButton>
    //{
    //    protected override UIKit.UIButton CreatePlatformView()
    //    {
    //        var platformView = new UIKit.UIButton();

    //        return platformView;
    //    }

    //    protected override void ConnectHandler(UIButton platformView)
    //    {
    //        base.ConnectHandler(platformView);
    //        platformView.VerticalAlignment = UIKit.UIControlContentVerticalAlignment.Center;
    //        platformView.HorizontalAlignment = UIKit.UIControlContentHorizontalAlignment.Left;

    //    }

    //    protected override void DisconnectHandler(UIButton platformView)
    //    {
    //        platformView.Dispose();
    //        base.DisconnectHandler(platformView);
    //    }

    //    public static IPropertyMapper<CustomButton, CustomButtonHandler> PropertyMapper = new PropertyMapper<CustomButton, CustomButtonHandler>(ViewHandler.ViewMapper)
    //    {
    //        [nameof(CustomButton.Text)] = MapText
    //    };

    //    public static void MapText(CustomButtonHandler handler, CustomButton customButton)
    //    {
    //        handler.PlatformView.SetTitle(customButton.Text, UIControlState.Normal);
    //    }

    //    public CustomButtonHandler() : base(PropertyMapper)
    //    {
    //    }
    //}

    partial class CustomButtonHandler : ButtonHandler
    {
        protected override UIButton CreatePlatformView()
        {
            return base.CreatePlatformView();
        }

        protected override void ConnectHandler(UIButton platformView)
        {
            base.ConnectHandler(platformView);
        }

        public static IPropertyMapper<CustomButton, CustomButtonHandler> PropertyMapper = new PropertyMapper<CustomButton, CustomButtonHandler>(ViewHandler.ViewMapper)
        {
            [nameof(CustomButton.Text)] = MapText
        };

        public static void MapText(CustomButtonHandler handler, CustomButton customButton)
        {
            handler.PlatformView.SetTitle(customButton.Text, UIControlState.Normal);
        }

        public CustomButtonHandler() : base(PropertyMapper)
        {
        }
    }
}

