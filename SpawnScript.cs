using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    private List<TreeInstance> TreeInstances;
    public LayerMask layer;
    public GameObject myPrefab;

    private int numberMushrooms;
    public static string saveListDataChampis;

    public GameObject ParentGameObject;
    // Start is called before the first frame update
    	void Start()
    	{
        saveListDataChampis = "{\"PositionsChampis\":[";
        for (int i = 0; i < 9; i++) {
		      	TreeInstances = new List<TreeInstance>(Terrain.activeTerrains[i].terrainData.treeInstances);
			for (int j = 0; j < TreeInstances.Count; j++) {
				int index = TreeInstances[j].prototypeIndex;

				if (Terrain.activeTerrains[i].terrainData.treePrototypes[index].prefab.layer == LayerMask.NameToLayer("Spawn")) {
					if (PlayerPrefs.HasKey("Number Mushroom")) {
    					numberMushrooms = PlayerPrefs.GetInt("Number Mushroom");
    				} else {
    					numberMushrooms = 100;
    					PlayerPrefs.SetInt("Number Mushroom", 100);
						PlayerPrefs.Save();
    				}

					int random = Random.Range(0, numberMushrooms);
					if(random == 1){
						float width = Terrain.activeTerrains[i].terrainData.size.x;
						float height = Terrain.activeTerrains[i].terrainData.size.z;
						float y = Terrain.activeTerrains[i].terrainData.size.y;

						Vector3 position = new Vector3(TreeInstances[j].position.x * width, TreeInstances[j].position.y*y, TreeInstances[j].position.z * height);
                        saveListDataChampis += JsonUtility.ToJson(position) + ","  ;

                        GameObject obj = Instantiate(myPrefab, position+Terrain.activeTerrains[i].GetPosition(), Quaternion.identity) as GameObject;
                        obj.transform.parent = ParentGameObject.transform;
					}
				}
			}
		}
    	}
}
