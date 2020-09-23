﻿namespace CUE4Parse.UE4.Versions
{
    // Unreal engine 4 versions, declared as enum to be able to see all revisions in a single place
    public enum UE4Version
    {
        // Pre-release UE4 file versions
        VER_UE4_ASSET_REGISTRY_TAGS = 112,
        VER_UE4_TEXTURE_DERIVED_DATA2 = 124,
        VER_UE4_ADD_COOKED_TO_TEXTURE2D = 125,
        VER_UE4_REMOVED_STRIP_DATA = 130,
        VER_UE4_REMOVE_EXTRA_SKELMESH_VERTEX_INFLUENCES = 134,
        VER_UE4_TEXTURE_SOURCE_ART_REFACTOR = 143,
        VER_UE4_ADD_SKELMESH_MESHTOIMPORTVERTEXMAP = 152,
        VER_UE4_REMOVE_ARCHETYPE_INDEX_FROM_LINKER_TABLES = 163,
        VER_UE4_REMOVE_NET_INDEX = 196,
        VER_UE4_BULKDATA_AT_LARGE_OFFSETS = 198,
        VER_UE4_SUMMARY_HAS_BULKDATA_OFFSET = 212,
        VER_UE4_STATIC_MESH_STORE_NAV_COLLISION = 216,
        VER_UE4_DEPRECATED_STATIC_MESH_THUMBNAIL_PROPERTIES_REMOVED = 242,
        VER_UE4_APEX_CLOTH = 254,
        VER_UE4_STATIC_SKELETAL_MESH_SERIALIZATION_FIX = 269,
        VER_UE4_SUPPORT_32BIT_STATIC_MESH_INDICES = 277,
        VER_UE4_APEX_CLOTH_LOD = 280,
        VAR_UE4_ARRAY_PROPERTY_INNER_TAGS = 282, // note: here's a typo in UE4 code - "VAR_" instead of "VER_"
        VER_UE4_KEEP_SKEL_MESH_INDEX_DATA = 283,
        VER_UE4_MOVE_SKELETALMESH_SHADOWCASTING = 302,
        VER_UE4_REFERENCE_SKELETON_REFACTOR = 310,
        VER_UE4_FIXUP_ROOTBONE_PARENT = 312,
        VER_UE4_FIX_ANIMATIONBASEPOSE_SERIALIZATION = 331,
        VER_UE4_SUPPORT_8_BONE_INFLUENCES_SKELETAL_MESHES = 332,
        VER_UE4_SUPPORT_GPUSKINNING_8_BONE_INFLUENCES = 334,
        VER_UE4_ANIM_SUPPORT_NONUNIFORM_SCALE_ANIMATION = 335,
        VER_UE4_ENGINE_VERSION_OBJECT = 336,
        VER_UE4_SKELETON_GUID_SERIALIZATION = 338,

        // UE4.0 source code was released on GitHub. Note: if we don't have any VER_UE4_...
        // values between two VER_UE4_xx constants, for instance, between VER_UE4_0 and VER_UE4_1,
        // it doesn't matter for this framework which version will be serialized serialized -
        // 4.0 or 4.1, because 4.1 has nothing new for supported object formats compared to 4.0.
        VER_UE4_0 = 342,
        VER_UE4_MORPHTARGET_CPU_TANGENTZDELTA_FORMATCHANGE = 348,
        VER_UE4_1 = 352,
        VER_UE4_2 = 363,
        VER_UE4_LOAD_FOR_EDITOR_GAME = 365,
        VER_UE4_FTEXT_HISTORY = 368, // used for UStaticMesh versioning
        VER_UE4_STORE_BONE_EXPORT_NAMES = 370,
        VER_UE4_3 = 382,
        VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP = 384,
        VER_UE4_4 = 385,
        VER_UE4_SKELETON_ADD_SMARTNAMES = 388,
        VER_UE4_SOUND_COMPRESSION_TYPE_ADDED = 392,
        VER_UE4_RENAME_CROUCHMOVESCHARACTERDOWN = 394, // used for UStaticMesh versioning
        VER_UE4_DEPRECATE_UMG_STYLE_ASSETS = 397, // used for UStaticMesh versioning
        VER_UE4_5 = 401,
        VER_UE4_6 = 413,
        VER_UE4_RENAME_WIDGET_VISIBILITY = 416, // used for UStaticMesh versioning
        VER_UE4_ANIMATION_ADD_TRACKCURVES = 417,
        VER_UE4_7 = 434,
        VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG = 441,
        VER_UE4_PACKAGE_SUMMARY_HAS_COMPATIBLE_ENGINE_VERSION = 444,
        VER_UE4_8 = 451,
        VER_UE4_SERIALIZE_TEXT_IN_PACKAGES = 459,
        VER_UE4_9 = 482,
        VER_UE4_10 = VER_UE4_9, // exactly the same file version for 4.9 and 4.10
        VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT = 485,
        VER_UE4_SOUND_CONCURRENCY_PACKAGE = 489, // used for UStaticMesh versioning
        VER_UE4_11 = 498,
        VER_UE4_INNER_ARRAY_TAG_INFO = 500,
        VER_UE4_PROPERTY_GUID_IN_PROPERTY_TAG = 503,
        VER_UE4_NAME_HASHES_SERIALIZED = 504,
        VER_UE4_12 = 504,
        VER_UE4_13 = 505,
        VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS = 507,
        VER_UE4_TemplateIndex_IN_COOKED_EXPORTS = 508,
        VER_UE4_14 = 508,
        VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT = 509,
        VER_UE4_ADDED_SEARCHABLE_NAMES = 510,
        VER_UE4_15 = 510,
        VER_UE4_64BIT_EXPORTMAP_SERIALSIZES = 511,
        VER_UE4_16 = 513,
        VER_UE4_17 = 513,
        VER_UE4_ADDED_SOFT_OBJECT_PATH = 514,
        VER_UE4_18 = 514,
        VER_UE4_ADDED_PACKAGE_SUMMARY_LOCALIZATION_ID = 516,
        VER_UE4_19 = 516,
        VER_UE4_20 = 516,
        VER_UE4_21 = 517,
        VER_UE4_22 = 517,
        VER_UE4_23 = 517,
        VER_UE4_ADDED_PACKAGE_OWNER = 518,
        VER_UE4_24 = 518,
        VER_UE4_25 = 518,
        VER_UE4_SKINWEIGHT_PROFILE_DATA_LAYOUT_CHANGES = 519,
        VER_UE4_26 = 519, //?? todo: review later
        //Add new ones here
        VER_UE4_LAST,
        VER_UE4_LATEST = VER_UE4_LAST - 1
    }
}