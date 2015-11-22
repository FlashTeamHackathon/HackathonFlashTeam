//
//  CadidateData.h
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import <Foundation/Foundation.h>
@class Candidate;
@interface CadidateData : NSObject
{
    
}
@property (nonatomic,strong) NSMutableArray *arrCandidate;
@property (nonatomic,strong) NSMutableArray *arrPotential;
@property (nonatomic,strong) NSMutableArray *arrApplied;
@property (nonatomic,strong) NSMutableArray *arrInterView;
@property (nonatomic,strong) NSMutableArray *arrInterViewed;
+ (instancetype)shareInstance ;
- (void)updateCadidateIsBookInterview:(BOOL)isBookInterview idCandidate:(NSString *)idCandidate;
- (Candidate *)getCandidateWithID:(NSString *)candidateID;
- (void)updateCadidateAffterInterView:(NSInteger)actualScore idCandidate:(NSString *)idCandidate;
@end
