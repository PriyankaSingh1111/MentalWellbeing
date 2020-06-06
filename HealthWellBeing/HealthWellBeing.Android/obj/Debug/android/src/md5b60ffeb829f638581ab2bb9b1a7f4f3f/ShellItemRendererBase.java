package md5b60ffeb829f638581ab2bb9b1a7f4f3f;


public abstract class ShellItemRendererBase
	extends android.support.v4.app.Fragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.ShellItemRendererBase, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", ShellItemRendererBase.class, __md_methods);
	}


	public ShellItemRendererBase ()
	{
		super ();
		if (getClass () == ShellItemRendererBase.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ShellItemRendererBase, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();

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
