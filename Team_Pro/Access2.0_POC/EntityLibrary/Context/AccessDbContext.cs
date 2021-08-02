/**
* @author udhayakumar_m
* @ reference CustomServiceLayer_MCD.pdf
*/

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Proxies;
using EntityLibrary.Context.Models;

namespace EntityLibrary.Context
{
    public class AccessDbContext : DbContext
    {
        public AccessDbContext()
        {
        }

        public AccessDbContext(DbContextOptions<AccessDbContext> options) : base(options)
        {
        }

        /************Totally 135 tables found in the given document ************/

        public DbSet<ExternalEcommSystem> ExternalEcommSystem { get; set; }
        public DbSet<SubscriptionBundleTypeToExternalEcom> SubscriptionBundleTypeToExternalEcom { get; set; }
        public DbSet<SubscriptionBundle> SubscriptionBundle { get; set; }
        public DbSet<SubscriptionBundleType> SubscriptionBundleType { get; set; }
        public DbSet<SubscriptionRecord> SubscriptionRecord { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlan { get; set; }
        public DbSet<SubscriptionBundleToPlan> SubscriptionBundleToPlan { get; set; }
        public DbSet<SubscriptionBundleToLearningContent> SubscriptionBundleToLearningContent { get; set; }
        public DbSet<TimeZone> TimeZone { get; set; }
        public DbSet<GeographicalArea> GeographicalArea { get; set; }
        public DbSet<GeographicalAreaToTimeZone> GeographicalAreaToTimeZone { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<ServiceDatabaseInfo> ServiceDatabaseInfo { get; set; }
        public DbSet<ITZone> ITZone { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<LanguageToTenant> LanguageToTenant { get; set; }
        public DbSet<GeographicalAreaToTenant> GeographicalAreaToTenant { get; set; }
        public DbSet<AuthProvider> AuthProvider { get; set; }
        public DbSet<AuthProviderToTenant> AuthProviderToTenant { get; set; }
        public DbSet<TenantSiteMap> TenantSiteMap { get; set; }
        public DbSet<TenantApplicationParameter> TenantApplicationParameter { get; set; }
        public DbSet<GlobalApplicationParameter> GlobalApplicationParameter { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<BrandAssignmentToTenant> BrandAssignmentToTenant { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<BusinessUserProfile> BusinessUserProfile { get; set; }
        public DbSet<UserAssignmentInTenant> UserAssignmentInTenant { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserGlobalAssignmentRole> UserGlobalAssignmentRole { get; set; }
        public DbSet<UserToBrand> UserToBrand { get; set; }
        public DbSet<UserAssignmentInTenantWithRole> UserAssignmentInTenantWithRole { get; set; }
        public DbSet<UserToBrandWithRole> UserToBrandWithRole { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<UserProfileRemindMeStatus> UserProfileRemindMeStatus { get; set; }
        public DbSet<UserProfileExperience> UserProfileExperience { get; set; }
        public DbSet<UserProfileSocialMediaLinks> UserProfileSocialMediaLinks { get; set; }
        public DbSet<SocialMediaType> SocialMediaType { get; set; }
        public DbSet<SalonType> SalonType { get; set; }
        public DbSet<SalonNature> SalonNature { get; set; }
        public DbSet<Salon> Salon { get; set; }
        public DbSet<SalonProfile> SalonProfile { get; set; }
        public DbSet<SalonAffiliation> SalonAffiliation { get; set; }
        public DbSet<SalonAffiliationType> SalonAffiliationType { get; set; }
        public DbSet<AssetStorageAccount> AssetStorageAccount { get; set; }
        public DbSet<AssetStorageAccountForTenant> AssetStorageAccountForTenant { get; set; }
        public DbSet<AssetPortfolioType> AssetPortfolioType { get; set; }
        public DbSet<AssetPortfolioTypeToStorageAccountForTenant> AssetPortfolioTypeToStorageAccountForTenant { get; set; }
        public DbSet<Asset> Asset { get; set; }
        public DbSet<AssetPortfolio> AssetPortfolio { get; set; }
        public DbSet<AssetToAssetPortfolio> AssetToAssetPortfolio { get; set; }
        public DbSet<SalonProfilePortfolio> SalonProfilePortfolio { get; set; }
        public DbSet<UserProfilePortfolio> UserProfilePortfolio { get; set; }
        public DbSet<TenantCMSConfiguration> TenantCMSConfiguration { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<AgendaEvent> AgendaEvent { get; set; }
        public DbSet<AgendaEventAttendees> AgendaEventAttendees { get; set; }
        public DbSet<AgendaEventLinkItemType> AgendaEventLinkItemType { get; set; }
        public DbSet<AgendaEventLinkedItems> AgendaEventLinkedItems { get; set; }
        public DbSet<EducatorTrackingActivityType> EducatorTrackingActivityType { get; set; }
        public DbSet<EducatorTrackingActivity> EducatorTrackingActivity { get; set; }
        public DbSet<UserInvitationRequest> UserInvitationRequest { get; set; }
        public DbSet<EducatorTrackingActivityAttendees> EducatorTrackingActivityAttendees { get; set; }
        public DbSet<Following_ActivityTracking_Notification> Following_ActivityTracking_Notification { get; set; }
        public DbSet<ContentActivityNotification> ContentActivityNotification { get; set; }
        public DbSet<FollowingContent> FollowingContent { get; set; }
        public DbSet<UIActionLabel> UIActionLabel { get; set; }
        public DbSet<ContentUniqueIdReferential> ContentUniqueIdReferential { get; set; }
        public DbSet<Translations> Translations { get; set; }
        public DbSet<LikeContentCompilation> LikeContentCompilation { get; set; }
        public DbSet<RatingContentCompilation> RatingContentCompilation { get; set; }
        public DbSet<LikeContent> LikeContent { get; set; }
        public DbSet<RatingContent> RatingContent { get; set; }
        public DbSet<ReviewTag> ReviewTag { get; set; }
        public DbSet<ReviewContent> ReviewContent { get; set; }
        public DbSet<ReviewContentToTag> ReviewContentToTag { get; set; }
        public DbSet<ReviewContentHistory> ReviewContentHistory { get; set; }
        public DbSet<ReviewContentCompilation> ReviewContentCompilation { get; set; }
        public DbSet<Perso_LearningContentRelationship_Config> Perso_LearningContentRelationship_Config { get; set; }
        public DbSet<UserBookmark> UserBookmark { get; set; }
        public DbSet<Perso_LearningContentRelationship> Perso_LearningContentRelationship { get; set; }
        public DbSet<TrendingRate_LearningContent> TrendingRate_LearningContent { get; set; }
        public DbSet<TrendingRate_LearningContent_Config> TrendingRate_LearningContent_Config { get; set; }
        public DbSet<TrendingRate_Hasthtag_Config> TrendingRate_Hasthtag_Config { get; set; }
        public DbSet<TrendingRate_Hashtag> TrendingRate_Hashtag { get; set; }
        public DbSet<ActivityTracking> ActivityTracking { get; set; }
        public DbSet<UserHashtagActivityRate> UserHashtagActivityRate { get; set; }
        public DbSet<UserVsUserHashtagActivityRate> UserVsUserHashtagActivityRate { get; set; }
        public DbSet<TenantCMSConfigurationForBrand> TenantCMSConfigurationForBrand { get; set; }
        public DbSet<TenantCMSTemplateMapping> TenantCMSTemplateMapping { get; set; }
        public DbSet<TenantCMSLearningContentSyncState> TenantCMSLearningContentSyncState { get; set; }
        public DbSet<TenantCMSLearningContentSyncStateHistory> TenantCMSLearningContentSyncStateHistory { get; set; }
        public DbSet<AssignmentRoleType> AssignmentRoleType { get; set; }
        public DbSet<UserAssignmentToLearningContent> UserAssignmentToLearningContent { get; set; }
        public DbSet<LMSSessionExtendedInfo> LMSSessionExtendedInfo { get; set; }
        public DbSet<LMSGamificationBadge> LMSGamificationBadge { get; set; }
        public DbSet<UserToLMSGamificationBadge> UserToLMSGamificationBadge { get; set; }
        public DbSet<LMSClassroom> LMSClassroom { get; set; }
        public DbSet<LMSLocation> LMSLocation { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<LMSCategoryAddField> LMSCategoryAddField { get; set; }
        public DbSet<LMSMainLearningCategory> LMSMainLearningCategory { get; set; }
        public DbSet<LMSAsset> LMSAsset { get; set; }
        public DbSet<LMSChannel> LMSChannel { get; set; }
        public DbSet<LMSAssetInLMSChannel> LMSAssetInLMSChannel { get; set; }
        public DbSet<LMSChannelExperts> LMSChannelExperts { get; set; }
        public DbSet<LMSChannelVisibility> LMSChannelVisibility { get; set; }
        public DbSet<CertificateLearningItemAssignment> CertificateLearningItemAssignment { get; set; }
        public DbSet<CertificateType> CertificateType { get; set; }
        public DbSet<CertificateTemplate> CertificateTemplate { get; set; }
        public DbSet<CertificateUserAssignment> CertificateUserAssignment { get; set; }
        public DbSet<ContentSecurityClaimsAuthorized> ContentSecurityClaimsAuthorized { get; set; }
        public DbSet<LMSLearningPlan> LMSLearningPlan { get; set; }
        public DbSet<LMSCatalog> LMSCatalog { get; set; }
        public DbSet<LMSCatalogToLearningPlan> LMSCatalogToLearningPlan { get; set; }
        public DbSet<LMSLearningCourse> LMSLearningCourse { get; set; }
        public DbSet<LMSLearningPlanToLearningCourse> LMSLearningPlanToLearningCourse { get; set; }
        public DbSet<LMSCatalogToLearningCourse> LMSCatalogToLearningCourse { get; set; }
        public DbSet<LMSLearningCourseAdditionalFields> LMSLearningCourseAdditionalFields { get; set; }
        public DbSet<LMSLearningWidgetType> LMSLearningWidgetType { get; set; }
        public DbSet<LMSPartner> LMSPartner { get; set; }
        public DbSet<LMSLearningSession> LMSLearningSession { get; set; }
        public DbSet<LMSLearningSessionEvent> LMSLearningSessionEvent { get; set; }
        public DbSet<LMSLearningSessionEventRecording> LMSLearningSessionEventRecording { get; set; }
        public DbSet<LMSLearningCourseToWidget> LMSLearningCourseToWidget { get; set; }
        public DbSet<LMSContentBrandRelationship> LMSContentBrandRelationship { get; set; }
        public DbSet<UserToLMSGroup> UserToLMSGroup { get; set; }
        public DbSet<LMSGroup> LMSGroup { get; set; }
        public DbSet<TenantToLMSGroup> TenantToLMSGroup { get; set; }
        public DbSet<LMSBranch> LMSBranch { get; set; }
        public DbSet<TenantToLMSCatalog> TenantToLMSCatalog { get; set; }
        public DbSet<TenantToLMSBranch> TenantToLMSBranch { get; set; }
        public DbSet<UserToLMSBranch> UserToLMSBranch { get; set; }
        public DbSet<LMSLearningCourseCategory> LMSLearningCourseCategory { get; set; }
        public DbSet<AccessTestTable> AccessTestTable { get; set; }


        //Stored Procedure declarations
        //public DbSet<SP_Out> Add_LMSMainCategory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"Server=CHL129428;User Id=access;Password=Access@123;Database=AccessDB");
            }
        }
    }
}
