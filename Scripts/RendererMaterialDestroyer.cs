using UnityEngine;

namespace Kogane.Internal
{
	internal sealed class RendererMaterialDestroyer : MonoBehaviour
	{
		private void OnDestroy()
		{
			var renderers = GetComponentsInChildren<Renderer>( true );

			for ( int i = 0; i < renderers.Length; i++ )
			{
				var materials = renderers[ i ].materials;

				for ( int j = 0; j < materials.Length; j++ )
				{
					Destroy( materials[ j ] );
				}
			}
		}
	}
}