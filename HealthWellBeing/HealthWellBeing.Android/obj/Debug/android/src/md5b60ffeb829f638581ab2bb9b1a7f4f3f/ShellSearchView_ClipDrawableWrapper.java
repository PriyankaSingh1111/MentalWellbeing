package md5b60ffeb829f638581ab2bb9b1a7f4f3f;


public class ShellSearchView_ClipDrawableWrapper
	extends android.graphics.drawable.DrawableWrapper
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.ShellSearchView+ClipDrawableWrapper, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", ShellSearchView_ClipDrawableWrapper.class, __md_methods);
	}


	public ShellSearchView_ClipDrawableWrapper (android.graphics.drawable.Drawable p0)
	{
		super (p0);
		if (getClass () == ShellSearchView_ClipDrawableWrapper.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ShellSearchView+ClipDrawableWrapper, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Graphics.Drawables.Drawable, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
