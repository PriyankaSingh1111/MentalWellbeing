package md5b60ffeb829f638581ab2bb9b1a7f4f3f;


public class ImageCache_FormsLruCache
	extends android.util.LruCache
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_sizeOf:(Ljava/lang/Object;Ljava/lang/Object;)I:GetSizeOf_Ljava_lang_Object_Ljava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.ImageCache+FormsLruCache, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", ImageCache_FormsLruCache.class, __md_methods);
	}


	public ImageCache_FormsLruCache (int p0)
	{
		super (p0);
		if (getClass () == ImageCache_FormsLruCache.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ImageCache+FormsLruCache, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}


	public int sizeOf (java.lang.Object p0, java.lang.Object p1)
	{
		return n_sizeOf (p0, p1);
	}

	private native int n_sizeOf (java.lang.Object p0, java.lang.Object p1);

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