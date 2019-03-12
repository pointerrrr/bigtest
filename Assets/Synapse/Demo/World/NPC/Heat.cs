using UnityEngine;
using System.Collections;

namespace Synapse
{
	namespace Demo
	{
		[AddComponentMenu("Synapse/Demo/NPC/Heat")]
		public class Heat : MonoBehaviour
		{
			public Gradient m_gradient;
			public float m_minimalMoveToHeat;
			public float m_heatSpeed;
			public float m_coldSpeed;
			
			private Renderer m_renderer;
			private Vector3 m_lastPosition;
			private float m_heatValue;
			
			void Start()
			{
				m_heatValue = 0.0f;
				m_renderer = GetComponentInChildren<Renderer>();
				m_lastPosition = transform.position;
				
				ApplyColor();
			}
			
			void Update()
			{
				Vector3 deltaMove = transform.position - m_lastPosition;
				if(deltaMove.sqrMagnitude >= m_minimalMoveToHeat * m_minimalMoveToHeat * Time.deltaTime)
				{
                    m_heatValue = 0;
				}
				else
				{
                    m_heatValue = 0;
				}
				m_lastPosition = transform.position;
				ApplyColor();
			}
			
			void ApplyColor()
			{
				Color color = m_gradient.Evaluate(m_heatValue);
				m_renderer.material.color = color;
			}
			
			public float HeatValue{ get{ return m_heatValue; } }
		}
	}
}
