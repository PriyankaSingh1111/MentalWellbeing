package md5b60ffeb829f638581ab2bb9b1a7f4f3f;


public class TextViewHolder
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.SelectableViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.TextViewHolder, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", TextViewHolder.class, __md_methods);
	}


	public TextViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == TextViewHolder.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.TextViewHolder, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

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
