//
//  Candidate.h
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Candidate : NSObject
{
    
}
@property (nonatomic)NSInteger score;
@property (nonatomic)NSInteger actualScore;
@property (nonatomic,strong)NSString *fullName;
@property (nonatomic,strong)NSString *des;
@property (nonatomic)NSInteger experience;
@property (nonatomic,strong)NSString* major;
@property (nonatomic,strong)NSString *jobTitle;
@property (nonatomic,strong) NSString *imageAvartar;
@property (nonatomic,strong)NSString *school;
@property (nonatomic,strong) NSString *phoneNumber;
@property (nonatomic) BOOL isMale;
@property (nonatomic) BOOL isHasInterview;
@property (nonatomic) BOOL isBookInterview;
@property (nonatomic) BOOL isAppliedInterview;
@property (nonatomic,strong) NSString *idCandidate;
@property (nonatomic,strong) NSString *address;
- (id)initWith:(NSString *)fullName des:(NSString *)des
    experience:(NSInteger )experience major:(NSString *)major jobTitle:(NSString *)jobTitle imageAvartar:(NSString *)imageAvartar school:(NSString *)school isMale:(BOOL)isMale isAppliedInterview:(BOOL)isAppliedInterview idCandidate:(NSString *)idCandidate score:(NSInteger)score phoneNumber:(NSString *)phoneNumber address:(NSString *)address;
@end
