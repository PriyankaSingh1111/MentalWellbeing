package md5b60ffeb829f638581ab2bb9b1a7f4f3f;


public class ColorChangeRevealDrawable
	extends android.graphics.drawable.AnimationDrawable
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.ColorChangeRevealDrawable, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", ColorChangeRevealDrawable.class, __md_methods);
	}


	public ColorChangeRevealDrawable ()
	{
		super ();
		if (getClass () == ColorChangeRevealDrawable.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ColorChangeRevealDrawable, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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