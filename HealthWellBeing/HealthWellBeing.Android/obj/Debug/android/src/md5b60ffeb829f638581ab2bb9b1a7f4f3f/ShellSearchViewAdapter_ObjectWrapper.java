package md5b60ffeb829f638581ab2bb9b1a7f4f3f;


public class ShellSearchViewAdapter_ObjectWrapper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_toString:()Ljava/lang/String;:GetToStringHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.ShellSearchViewAdapter+ObjectWrapper, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", ShellSearchViewAdapter_ObjectWrapper.class, __md_methods);
	}


	public ShellSearchViewAdapter_ObjectWrapper ()
	{
		super ();
		if (getClass () == ShellSearchViewAdapter_ObjectWrapper.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ShellSearchViewAdapter+ObjectWrapper, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public java.lang.String toString ()
	{
		return n_toString ();
	}

	private native java.lang.String n_toString ();

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
